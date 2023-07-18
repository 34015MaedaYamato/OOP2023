using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();


        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void stasLabelDisp(string msg = "") {
            //MessageBox.Show(msg);
            tsInfoText.Text = msg;
        }
        
        //追加ボタン
        private void btAddReport_Click(object sender, EventArgs e) {
            stasLabelDisp();
            if (WriterName.Text == "") {
                stasLabelDisp("記録者を入力してください");
                return;
            }else if(CarName.Text == ""){
                stasLabelDisp("車名を入力してください");
                return;
            }

            CarReport NewRepo = new CarReport();
            NewRepo.Date = dtpDate.Value;
            NewRepo.Auther = WriterName.Text;
            NewRepo.Maker = getSelectedMaker();
            NewRepo.CarName = CarName.Text;
            NewRepo.Report = ReportBox.Text;
            NewRepo.CarImage = pbCarImage.Image;

            CarReports.Add(NewRepo);

            /*if (WriterName.Items.Contains(WriterName.Text)) {
                WriterName.Items.Add(WriterName.Text);
            }*/
            setWriterName(WriterName.Text);
            setCarName(CarName.Text);

            editItemsClear();
        }

        //記録者コンボボックス
        private void setWriterName(string Name) {
            if (!WriterName.Items.Contains(Name)) {
                WriterName.Items.Add(Name);
            }
        }
        //車名コンボボックス
        private void setCarName(string Name) {
            if (!CarName.Items.Contains(Name)) {
                CarName.Items.Add(Name);
            }
        }


        //項目クリア
        private void editItemsClear() {
            WriterName.Text = "";
            setSelectedMaker(CarReport.MakerGroup.トヨタ);
            CarName.Text = "";
            ReportBox.Text = "";
            pbCarImage.Image = null;

            dgvCarReports.ClearSelection();     //選択解除
            btUpDateReport.Enabled = false;
            btDleReport.Enabled = false;
        }

        //削除ボタン
        private void btDleReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
        }

        //修正ボタン
        private void btUpDateReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
                CarReports[dgvCarReports.CurrentRow.Index].Auther = WriterName.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
                CarReports[dgvCarReports.CurrentRow.Index].CarName = CarName.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Report = ReportBox.Text;
                dgvCarReports.Refresh();    //一覧更新
            }
        }

        //ラジオボタンで選択されているメーカーを返す
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in MakerGroup.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;

            /*if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rbImported.Checked) {
                return CarReport.MakerGroup.輸入車;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            } else if (rbSuzuki.Checked) {
                return CarReport.MakerGroup.スズキ;
            } else if (rbDaihatsu.Checked) {
                return CarReport.MakerGroup.ダイハツ;
            }
            return CarReport.MakerGroup.その他;*/
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                rbToyota.Checked = true;
                break;
                case CarReport.MakerGroup.日産:
                rbNissan.Checked = true;
                break;
                case CarReport.MakerGroup.ホンダ:
                rbHonda.Checked = true;
                break;
                case CarReport.MakerGroup.スバル:
                rbSubaru.Checked = true;
                break;
                case CarReport.MakerGroup.スズキ:
                rbSuzuki.Checked = true;
                break;
                case CarReport.MakerGroup.ダイハツ:
                rbDaihatsu.Checked = true;
                break;
                case CarReport.MakerGroup.輸入車:
                rbImported.Checked = true;
                break;
                case CarReport.MakerGroup.その他:
                rbOther.Checked = true;
                break;
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
            btUpDateReport.Enabled = false;
            btDleReport.Enabled = false;
        }

        //画像開くボタン
        private void OpenImage_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        

        //画像削除ボタン
        private void DeleteImage_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        //レポート選択
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            WriterName.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            CarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            ReportBox.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

            btUpDateReport.Enabled = false;
            btDleReport.Enabled = false;
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(ColorDialog.ShowDialog() == DialogResult.OK) {
                BackColor = ColorDialog.Color;
            } 
        }
    }
}
