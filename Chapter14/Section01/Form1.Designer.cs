
namespace Section01 {
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
            this.btRunNotePad = new System.Windows.Forms.Button();
            this.btRunAundWaitNotepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotePad
            // 
            this.btRunNotePad.Location = new System.Drawing.Point(28, 32);
            this.btRunNotePad.Name = "btRunNotePad";
            this.btRunNotePad.Size = new System.Drawing.Size(146, 42);
            this.btRunNotePad.TabIndex = 0;
            this.btRunNotePad.Text = "RunNotePad";
            this.btRunNotePad.UseVisualStyleBackColor = true;
            this.btRunNotePad.Click += new System.EventHandler(this.btRunNotePad_Click);
            // 
            // btRunAundWaitNotepad
            // 
            this.btRunAundWaitNotepad.Location = new System.Drawing.Point(33, 102);
            this.btRunAundWaitNotepad.Name = "btRunAundWaitNotepad";
            this.btRunAundWaitNotepad.Size = new System.Drawing.Size(140, 48);
            this.btRunAundWaitNotepad.TabIndex = 1;
            this.btRunAundWaitNotepad.Text = "RunAundWaitNotepad";
            this.btRunAundWaitNotepad.UseVisualStyleBackColor = true;
            this.btRunAundWaitNotepad.Click += new System.EventHandler(this.btRunAundWaitNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 237);
            this.Controls.Add(this.btRunAundWaitNotepad);
            this.Controls.Add(this.btRunNotePad);
            this.Name = "Form1";
            this.Text = "14章1節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotePad;
        private System.Windows.Forms.Button btRunAundWaitNotepad;
    }
}

