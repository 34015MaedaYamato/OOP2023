using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();
        BindingList<ItemData> RssList = new BindingList<ItemData>();

        public Form1() {
            InitializeComponent();
            dgvFavorite.DataSource = RssList;
            RssList.Add(new ItemData { Title = "国内", Link = "https://news.yahoo.co.jp/rss/categories/domestic.xml" });
            RssList.Add(new ItemData { Title = "国際", Link = "https://news.yahoo.co.jp/rss/categories/world.xml" });
            RssList.Add(new ItemData { Title = "経済", Link = "https://news.yahoo.co.jp/rss/categories/business.xml" });
            RssList.Add(new ItemData { Title = "IT", Link = "https://news.yahoo.co.jp/rss/topics/it.xml" });
        }

        //取得ボタンクリック
        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") {
                MessageBox.Show("URLを入力してください");
                return;
            }
            Url_Load();
        }

        //urlからタイトル一覧を取得する処理をメソッド化
        private void Url_Load() {
            lbRssTitle.Items.Clear();
            ItemDatas.Clear();

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);
                var nodes = xdoc.Root.Descendants("item")
                    .Select(x => new ItemData {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link")
                    }).ToList(); //titleとlinkを取得
                foreach (var node in nodes) {
                    lbRssTitle.Items.Add(node.Title);
                    ItemDatas.Add(node);
                }
                //先生
                /*ItemDatas = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = (string)x.Element("title"), Link = (string)x.Element("link") }).ToList();
                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }*/
            }
        }

        //タイトル一覧のリストボックス選択
        private void lbRssTitle_Click(object sender, EventArgs e) {
            var link = ItemDatas.Single(x => x.Title == lbRssTitle.Text);
            webBrowser.Navigate(link.Link);
            //先生
            //webBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);　
        }

        //お気に入り登録ボタンクリック
        private void btAdd_Click(object sender, EventArgs e) {
            if(tbUrl.Text == "") {
                MessageBox.Show("URLを入力してください");
                return;
            }
            if (tbLinkName.Text == "") {
                MessageBox.Show("お気に入り名を入力してください");
                return;
            }
            if (RssList.Select(x => x.Link).Contains(tbUrl.Text)) {
                MessageBox.Show("このURLは既に登録されています");
                return;
            }
            RssList.Add(new ItemData { Title = tbLinkName.Text, Link = tbUrl.Text });
            
        }

        //お気に入りDataGridView選択
        private void dgvFavorite_CellClick(object sender, DataGridViewCellEventArgs e) {
            tbUrl.Text = (string)dgvFavorite.CurrentRow.Cells[1].Value;
            Url_Load();
        }
    }
}
