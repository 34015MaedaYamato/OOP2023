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
            btAddReport.Enabled = true;
        }

        //削除ボタン
        private void btDleReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
        }

        //修正ボタン
        private void btUpDateReport_Click(object sender, EventArgs e) {

        }


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

        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                break;
                case CarReport.MakerGroup.日産:
                break;
                case CarReport.MakerGroup.ホンダ:
                break;
                case CarReport.MakerGroup.スバル:
                break;
                case CarReport.MakerGroup.スズキ:
                break;
                case CarReport.MakerGroup.ダイハツ:
                break;
                case CarReport.MakerGroup.輸入車:
                break;
                case CarReport.MakerGroup.その他:
                break;
                default:
                break;
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
            //btUpDateReport.Enabled = false;
            //btDleReport.Enabled = false;
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
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }
    }
}
