using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTracker
{
    public partial class LibraryUserControl : UserControl
    {
        public Config Config { get; set; }
        string[] seriale;
        string[] episoade;
        public LibraryUserControl()
        {
            InitializeComponent();
        }

        public void LoadSeries()
        {
            seriale = Directory.GetDirectories(Config.SeriesPath);
            serialeLb.Controls.Clear();
            itemsTable.Controls.Clear();
            foreach (string s in seriale)
            {
                DirectoryInfo info = new DirectoryInfo(s);
                serialeLb.Items.Add(info.Name);
            }
        }
        void PopulateEpisodes()
        {
            itemsTable.Controls.Clear();
            itemsTable.RowCount = episoade.Length;
            for (int i = 0; i < episoade.Length; ++i)
            {
                FileInfo info = new FileInfo(episoade[i]);
                var element = new ListElement(info.Name, episoade[i], Config);
                element.ButtonText = "Play";
                element.ElementAction = () =>
                {
                    Process.Start(Config.PlayerPath, element.ElementLink);
                };
                element.Dock = DockStyle.Fill;
                itemsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, element.Height + 10));
                itemsTable.Controls.Add(element, 0, i);
            }
        }
        public void LoadEpisodes(int index)
        {
            episoade = Directory.GetFiles(seriale[index]);
                PopulateEpisodes();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadSeries();
        }

        private void serialeLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialeLb.SelectedIndex < 0)
                return;
            LoadEpisodes(serialeLb.SelectedIndex);
        }
    }
}
