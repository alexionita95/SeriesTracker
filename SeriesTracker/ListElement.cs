using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTracker
{
    public partial class ListElement : UserControl
    {
        public string ElementTitle { get { return titleLbl.Text;  } set { titleLbl.Text = value; titleToolTip.SetToolTip(titleLbl, value); } }
        public string ElementLink{ get; set; }
        public string ElementDate { get { return dateLbl.Text; } set { dateLbl.Text = value; } }
        public string ElementSize { get { return sizeLbl.Text; } set { sizeLbl.Text = value;} }
        public string ButtonText { get { return downloadBtn.Text; } set { downloadBtn.Text = value; } }
        private Config config;
        public Action ElementAction { get; set; }
        public ListElement()
        {
            InitializeComponent();
        }
        public ListElement(string title, string link, string date, string size,Config cfg)
        {
            InitializeComponent();
            ElementTitle = title;
            ElementLink = link;
            ElementDate = date;
            ElementSize = size;
            config = cfg;
        }
        public ListElement(string title, string path,Config cfg)
        {
            InitializeComponent();
            ElementTitle = title;
            ElementDate = "";
            ElementSize = "";
            ElementLink = path;
            config = cfg;

        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            ElementAction?.Invoke();
        }

        private async void DownloadTorrent()
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += (sender, args) =>
            {
                Debug.WriteLine(args.ProgressPercentage);  
            };
            client.DownloadFileCompleted += (sender, args) =>
            {
                Debug.WriteLine("Complete");
                Debug.WriteLine($"{AppDomain.CurrentDomain.BaseDirectory}\\{ElementTitle}.torrent");
                Process.Start(config.TorrentSwPath,$"{AppDomain.CurrentDomain.BaseDirectory}\\{ElementTitle}.torrent");
            };
            client.DownloadFileAsync(new Uri(ElementLink),$"{ElementTitle}.torrent");
  

        }
    }
}
