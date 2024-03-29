﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        PictureBoxSizeMode mode = 0;


        //設定保存用
        Settings settings = new Settings {
            MainFormColor = DefaultBackColor.ToArgb()
        };


        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
            stasLabelDisp(); //ステータスラベル初期化

        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void stasLabelDisp(string msg = "") {
            //MessageBox.Show(msg);
            tsInfo.Text = msg;
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
            NewRepo.Author = WriterName.Text;
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

        //記録者コンボボックス 履歴登録
        private void setWriterName(string Name) {
            if (!WriterName.Items.Contains(Name)) {
                WriterName.Items.Add(Name);
            }
        }
        //車名コンボボックス　履歴登録
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
                CarReports[dgvCarReports.CurrentRow.Index].Author = WriterName.Text;
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

            tsInfoText.Text = ""; //表示領域のテキストを初期化
            tsTimeDisp.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
            tsTimeDisp.BackColor = Color.Black;
            tsTimeDisp.ForeColor = Color.White;
            TimeUpdate.Start();　//時刻更新用のタイマー

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.AliceBlue; //全体の背景を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite; //奇数業の背景を上書き

            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
            btUpDateReport.Enabled = false;
            btDleReport.Enabled = false;
            
            try {
                //設定ファイルを逆シリアル化して背景を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message+":設定ファイル読み込みエラー");
            }
            
        }

        //画像開くボタン
        private void OpenImage_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }

        

        //画像削除ボタン
        private void DeleteImage_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        //レポート選択
        private void dgvCarReports_Click(object sender, EventArgs e) {
           /* if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                WriterName.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                CarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                ReportBox.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                btUpDateReport.Enabled = true; //修正ボタン有効
                btDleReport.Enabled = true;　//削除ボタン有効
            }*/
        }
        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                WriterName.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                CarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                ReportBox.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                btUpDateReport.Enabled = true; //修正ボタン有効
                btDleReport.Enabled = true;　//削除ボタン有効
            }
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(ColorDialog.ShowDialog() == DialogResult.OK) {
                BackColor = ColorDialog.Color;
                settings.MainFormColor = ColorDialog.Color.ToArgb();
            } 
        }

        private void ImageResize_Click(object sender, EventArgs e) {
            //mode = mode < 4 ? ((mode == 1) ? 3: ++mode) : 0;
            /*pbCarImage.SizeMode = mode < PictureBoxSizeMode.Zoom ? ((mode == PictureBoxSizeMode.StretchImage) ? PictureBoxSizeMode.CenterImage : ++mode)//AutoSize(2)を除外
                                  : PictureBoxSizeMode.Normal;*/

            if (mode < PictureBoxSizeMode.Zoom) {
                if (mode == PictureBoxSizeMode.StretchImage) {
                    mode = PictureBoxSizeMode.CenterImage;
                } else {
                    ++mode;
                }
            } else {
                mode = PictureBoxSizeMode.Normal;
            }

            pbCarImage.SizeMode = mode;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using(var Writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(Writer, settings);
            }
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void TimeUpdate_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("yyyy年MM月dd日HH時mm分ss秒");
        }

        

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                    bf.Serialize(fs, CarReports);
                    }
                }catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void 開くToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
                    var bf = new BinaryFormatter();
                    using(FileStream fs = File.Open(ofdCarRepoOpen.FileName, FileMode.Open,FileAccess.Read)) {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;

                        editItemsClear();//入力途中などのデータはすべてクリア

                        dgvCarReports.Columns[5].Visible = false;   //画像項目非表示

                        foreach (var carReport in CarReports) {
                            setWriterName(carReport.Author);
                            setCarName(carReport.CarName);
                        }
                        //または、
                        /*foreach (var author in CarReports.Select(p => p.Author)) {
                            setWriterName(author);
                        }
                        foreach (var report in CarReports.Select(p => p.Report)) {
                            setCarName(report);
                        }*/

                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
