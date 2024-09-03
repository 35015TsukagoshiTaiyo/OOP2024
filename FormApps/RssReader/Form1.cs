﻿using System;
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
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                
                var items = xdoc.Descendants("item").Select(x => new {
                    title = x.Element("title").Value,
                    link = x.Element("link").Value,
                });
                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.title);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            var value = lbRssTitle.SelectedItem;
        }
    }
}
