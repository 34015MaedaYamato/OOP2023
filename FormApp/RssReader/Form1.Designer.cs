﻿
namespace RssReader {
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.dgvFavorite = new System.Windows.Forms.DataGridView();
            this.tbLinkName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(729, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(747, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(68, 30);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 73);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(283, 208);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 287);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(803, 406);
            this.webBrowser.TabIndex = 3;
            // 
            // dgvFavorite
            // 
            this.dgvFavorite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorite.Location = new System.Drawing.Point(338, 81);
            this.dgvFavorite.Name = "dgvFavorite";
            this.dgvFavorite.RowTemplate.Height = 21;
            this.dgvFavorite.Size = new System.Drawing.Size(409, 166);
            this.dgvFavorite.TabIndex = 4;
            // 
            // tbLinkName
            // 
            this.tbLinkName.Location = new System.Drawing.Point(420, 50);
            this.tbLinkName.Name = "tbLinkName";
            this.tbLinkName.Size = new System.Drawing.Size(320, 19);
            this.tbLinkName.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(764, 54);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(68, 33);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "お気に入り登録";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 705);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbLinkName);
            this.Controls.Add(this.dgvFavorite);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.DataGridView dgvFavorite;
        private System.Windows.Forms.TextBox tbLinkName;
        private System.Windows.Forms.Button btAdd;
    }
}

