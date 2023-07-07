
namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.WriterName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MakerGroup = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDaihatsu = new System.Windows.Forms.RadioButton();
            this.rbImported = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CarName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReportBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OpenImage = new System.Windows.Forms.Button();
            this.DeleteImage = new System.Windows.Forms.Button();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btMvReport = new System.Windows.Forms.Button();
            this.btDleReport = new System.Windows.Forms.Button();
            this.MakerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(81, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "記録者：";
            // 
            // WriterName
            // 
            this.WriterName.FormattingEnabled = true;
            this.WriterName.Location = new System.Drawing.Point(81, 52);
            this.WriterName.Name = "WriterName";
            this.WriterName.Size = new System.Drawing.Size(219, 20);
            this.WriterName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "メーカー：";
            // 
            // MakerGroup
            // 
            this.MakerGroup.Controls.Add(this.rbOther);
            this.MakerGroup.Controls.Add(this.rbDaihatsu);
            this.MakerGroup.Controls.Add(this.rbImported);
            this.MakerGroup.Controls.Add(this.rbSuzuki);
            this.MakerGroup.Controls.Add(this.rbSubaru);
            this.MakerGroup.Controls.Add(this.rbHonda);
            this.MakerGroup.Controls.Add(this.rbNissan);
            this.MakerGroup.Controls.Add(this.rbToyota);
            this.MakerGroup.Location = new System.Drawing.Point(81, 78);
            this.MakerGroup.Name = "MakerGroup";
            this.MakerGroup.Size = new System.Drawing.Size(282, 98);
            this.MakerGroup.TabIndex = 5;
            this.MakerGroup.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(205, 67);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 7;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbDaihatsu
            // 
            this.rbDaihatsu.AutoSize = true;
            this.rbDaihatsu.Location = new System.Drawing.Point(137, 67);
            this.rbDaihatsu.Name = "rbDaihatsu";
            this.rbDaihatsu.Size = new System.Drawing.Size(60, 16);
            this.rbDaihatsu.TabIndex = 5;
            this.rbDaihatsu.TabStop = true;
            this.rbDaihatsu.Text = "ダイハツ";
            this.rbDaihatsu.UseVisualStyleBackColor = true;
            // 
            // rbImported
            // 
            this.rbImported.AutoSize = true;
            this.rbImported.Location = new System.Drawing.Point(205, 23);
            this.rbImported.Name = "rbImported";
            this.rbImported.Size = new System.Drawing.Size(59, 16);
            this.rbImported.TabIndex = 6;
            this.rbImported.TabStop = true;
            this.rbImported.Text = "輸入車";
            this.rbImported.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(71, 67);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(52, 16);
            this.rbSuzuki.TabIndex = 4;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Text = "スズキ";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(6, 67);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(137, 23);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 2;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(71, 23);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 1;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 23);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "車名：";
            // 
            // CarName
            // 
            this.CarName.FormattingEnabled = true;
            this.CarName.Location = new System.Drawing.Point(81, 182);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(218, 20);
            this.CarName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "レポート：";
            // 
            // ReportBox
            // 
            this.ReportBox.Location = new System.Drawing.Point(81, 210);
            this.ReportBox.Multiline = true;
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.Size = new System.Drawing.Size(282, 145);
            this.ReportBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "画像：";
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(423, 24);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(74, 19);
            this.OpenImage.TabIndex = 12;
            this.OpenImage.Text = "開く";
            this.OpenImage.UseVisualStyleBackColor = true;
            // 
            // DeleteImage
            // 
            this.DeleteImage.Location = new System.Drawing.Point(505, 23);
            this.DeleteImage.Name = "DeleteImage";
            this.DeleteImage.Size = new System.Drawing.Size(87, 20);
            this.DeleteImage.TabIndex = 13;
            this.DeleteImage.Text = "削除";
            this.DeleteImage.UseVisualStyleBackColor = true;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Location = new System.Drawing.Point(81, 371);
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.Size = new System.Drawing.Size(511, 130);
            this.dgvCarReports.TabIndex = 14;
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.Color.White;
            this.pbCarImage.Location = new System.Drawing.Point(386, 67);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(206, 174);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarImage.TabIndex = 15;
            this.pbCarImage.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddReport.Location = new System.Drawing.Point(384, 269);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(65, 48);
            this.btAddReport.TabIndex = 16;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = false;
            this.btAddReport.Click += new System.EventHandler(this.btAddReport_Click);
            // 
            // btMvReport
            // 
            this.btMvReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btMvReport.Location = new System.Drawing.Point(455, 269);
            this.btMvReport.Name = "btMvReport";
            this.btMvReport.Size = new System.Drawing.Size(65, 48);
            this.btMvReport.TabIndex = 17;
            this.btMvReport.Text = "修正";
            this.btMvReport.UseVisualStyleBackColor = false;
            // 
            // btDleReport
            // 
            this.btDleReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDleReport.Location = new System.Drawing.Point(526, 269);
            this.btDleReport.Name = "btDleReport";
            this.btDleReport.Size = new System.Drawing.Size(65, 48);
            this.btDleReport.TabIndex = 18;
            this.btDleReport.Text = "削除";
            this.btDleReport.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 530);
            this.Controls.Add(this.btDleReport);
            this.Controls.Add(this.btMvReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.DeleteImage);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReportBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MakerGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WriterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MakerGroup.ResumeLayout(false);
            this.MakerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WriterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox MakerGroup;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbDaihatsu;
        private System.Windows.Forms.RadioButton rbImported;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReportBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.Button DeleteImage;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btMvReport;
        private System.Windows.Forms.Button btDleReport;
    }
}

