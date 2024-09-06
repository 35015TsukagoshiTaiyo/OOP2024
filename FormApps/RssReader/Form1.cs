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
    public partial class Form1 : Form {
        List<ItemData> items;
        List<ItemData> topics;
        public Form1() {
            InitializeComponent();
            //lbRssTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitializeWebView();
            topics_data();
        }
        private async void InitializeWebView() {
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // WebView2 コントロールを初期化します
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void topics_data() {
            topics = new List<ItemData> {
                new ItemData { Title = "主要", Link = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
                new ItemData { Title = "国内", Link = "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
                new ItemData { Title = "国際", Link = "https://news.yahoo.co.jp/rss/topics/world.xml" },
                new ItemData { Title = "経済", Link = "https://news.yahoo.co.jp/rss/topics/business.xml" },
                new ItemData { Title = "エンタメ", Link = "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
                new ItemData { Title = "スポーツ", Link = "https://news.yahoo.co.jp/rss/topics/sports.xml" },
                new ItemData { Title = "IT", Link = "https://news.yahoo.co.jp/rss/topics/it.xml" },
                new ItemData { Title = "科学", Link = "https://news.yahoo.co.jp/rss/topics/science.xml" },
                new ItemData { Title = "地域", Link = "https://news.yahoo.co.jp/rss/topics/local.xml" },
            };
            foreach (ItemData item in topics) {
                cbRssUrl.Items.Add(item.Title);
            }
        }
        private string getLink(string element) {
            var topic = topics.FirstOrDefault(x => x.Title == element);
            if (topic == null) {
                return element;
            }
            return topic.Link;
        }

        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();

            try {
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(getLink(cbRssUrl.Text));
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
            catch (Exception) {
                MessageBox.Show($"入力形式が正しくありません。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
        }

        private void btFavorite_Click(object sender, EventArgs e) {
            if (tbFavorite.Text == "") {
                MessageBox.Show("何も入力されていません");
                return;
            }
            if (cbRssUrl.Text == "") {
                MessageBox.Show("正しいURL又はお気に入り名称が入力されていません。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var item = new ItemData {
                Title = tbFavorite.Text,
                Link = cbRssUrl.Text,
            };
            topics.Add(item);
            cbRssUrl.Items.Add(item.Title);
            clear();
        }

        private void clear() {
            cbRssUrl.Text = null;
            tbFavorite.Clear();
            lbRssTitle.Items.Clear();
            webView21.CoreWebView2.Navigate("about:blank");
        }

        private void Form1_Resize(object sender, EventArgs e) {

        }
    }
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
