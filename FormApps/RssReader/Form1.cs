using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace RssReader {
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
    public partial class Form1 : Form {
        List<ItemData> items;
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item").Select(x => new ItemData {
                    Title = x.Element("title").Value,
                    Link = x.Element("link").Value,
                }).ToList();
                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webView1.Navigate(items[lbRssTitle.SelectedIndex].Link);
        }

        private void btFavorite_Click(object sender, EventArgs e) {
            
        }
    }
}
