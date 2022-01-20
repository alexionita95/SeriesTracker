namespace SeriesTracker
{
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Xml;


    public partial class MainForm : Form
    {
        private Config config;
        HttpClient client;
        public MainForm()
        {
            InitializeComponent();
        }

        private async void LoadFeed()
        {
            this.Invoke(new Action(() =>
            {
                
                itemsTable.Controls.Clear();
                itemsTable.ColumnCount = 1;
                itemsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            }));
            string data = await Get(config.Url);
           // Debug.WriteLine(data);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);
            var seriale = doc.SelectNodes("//rss/channel/item");
            Debug.WriteLine($"Seriale: {seriale.Count}");
            var lista = GetSeriale(seriale);
            Debug.WriteLine(lista.Count);
            this.Invoke(new Action(() =>
            {
                itemsTable.RowCount = lista.Count;
                for (int i = 0; i < lista.Count; ++i)
                {
                    var serial = lista[i];
                    var element = new ListElement(serial.Title, serial.Link, serial.Date, serial.Size, config);
                    element.ElementAction = () =>
                    {
                        WebClient client = new WebClient();
                        client.DownloadProgressChanged += (sender, args) =>
                        {
                            Debug.WriteLine(args.ProgressPercentage);
                        };
                        client.DownloadFileCompleted += (sender, args) =>
                        {
                            Debug.WriteLine("Complete");
                            Debug.WriteLine($"{AppDomain.CurrentDomain.BaseDirectory}\\{element.ElementTitle}.torrent");
                            Process.Start(config.TorrentSwPath, $"{AppDomain.CurrentDomain.BaseDirectory}\\{element.ElementTitle}.torrent");
                        };
                        client.DownloadFileAsync(new Uri(element.ElementLink), $"{element.ElementTitle}.torrent");

                    };
                    element.Dock = DockStyle.Fill;
                    itemsTable.RowStyles.Add(new RowStyle(SizeType.AutoSize,element.Height+10));
                    itemsTable.Controls.Add(element, 0, i);
                }
            }));
        }

        private List<Serial> GetSeriale(XmlNodeList seriale)
        {
            List<Serial> result = new List<Serial>();

            for (int i = 0; i < seriale.Count; ++i)
            {
                var title = seriale[i].SelectSingleNode("title").InnerText;
                var description = seriale[i].SelectSingleNode("description").InnerText;
                var size = GetSize(description);

                if (IsInFilter(title) && IsPreferedResolution(title, config.Resolution))
                {
                    var serial = new Serial(){ Title = title, Size = size, Link = seriale[i].SelectSingleNode("link").InnerText, Date = seriale[i].SelectSingleNode("pubDate").InnerText };
                result.Add(serial); 
                }
            }
                    return result;
        }
        private string GetSize(string description)
        {
            var list = description.Trim().Split("\n");
            foreach(string item in list)
            {
                if (item.Contains("Size"))
                    return item;
            }
            return string.Empty;
        }
        public async Task<string> Get(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                Debug.WriteLine($"Loading...");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

               
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return string.Empty;
        }
        bool IsInFilter(string title)
        {
            if (config.Filter.Count == 0) return true;
            
            foreach(var filter in config.Filter)
            {
                if(title.ToLower().Contains(filter.ToLower()))
                {
                    return true;
                }
            }
            
            return false;
        }
        bool IsPreferedResolution(string title,string resolution)
        {
            return title.ToLower().Contains(resolution.ToLower());
        }
        private void PopulateFilterList()
        {
            filterList.Items.Clear();
            foreach(var filter in config.Filter)
            {
                filterList.Items.Add(filter);
            }    
        }
        private void SaveFilter()
        {
            StreamWriter streamWriter = new StreamWriter("config.json");
            string json = Config.ToJson(config);
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine($"Loading...{Environment.ProcessPath}");
            if (File.Exists("config.json"))
            {
                StreamReader streamReader = new StreamReader("config.json");
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                config = Config.FromJson(json);
                client = new HttpClient();
               
                PopulateFilterList();
                comboBox1.SelectedItem = config.Resolution;
                libraryUserControl1.Config= config;
                libraryUserControl1.LoadSeries();
            }
            else
            {
                Debug.WriteLine($"Config file not found...{Environment.ProcessPath}");
            }
        }

        private void removeFilterItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedFilter();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(filterTxt.Text !=string.Empty)
            {
                config.Filter.Add(filterTxt.Text);
                filterTxt.Clear();
                PopulateFilterList();
                LoadFeed();
            }
        }
        void RemoveSelectedFilter()
        {
            int index = filterList.SelectedIndex;
            if (index == -1)
                return;
            config.Filter.RemoveAt(index);
            PopulateFilterList();
            LoadFeed();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadFeed();
        }

        private void filterList_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                RemoveSelectedFilter();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index=comboBox1.SelectedIndex;
            if (index == -1)
                return;
            config.Resolution = comboBox1.SelectedItem.ToString();
            LoadFeed();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFilter();
        }
    }
    class Serial
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
    }
}