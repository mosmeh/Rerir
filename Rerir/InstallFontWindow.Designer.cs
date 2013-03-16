namespace Rerir
{
    partial class InstallFontWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SelectAll = new System.Windows.Forms.Button();
            this.button_UnselectAll = new System.Windows.Forms.Button();
            this.button_Install = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(17, 77);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(337, 130);
            this.checkedListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "インストールするフォントを選択してください";
            // 
            // button_SelectAll
            // 
            this.button_SelectAll.Location = new System.Drawing.Point(17, 47);
            this.button_SelectAll.Name = "button_SelectAll";
            this.button_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.button_SelectAll.TabIndex = 3;
            this.button_SelectAll.Text = "全選択";
            this.button_SelectAll.UseVisualStyleBackColor = true;
            this.button_SelectAll.Click += new System.EventHandler(this.button_SelectAll_Click);
            // 
            // button_UnselectAll
            // 
            this.button_UnselectAll.Location = new System.Drawing.Point(98, 47);
            this.button_UnselectAll.Name = "button_UnselectAll";
            this.button_UnselectAll.Size = new System.Drawing.Size(75, 23);
            this.button_UnselectAll.TabIndex = 4;
            this.button_UnselectAll.Text = "全選択解除";
            this.button_UnselectAll.UseVisualStyleBackColor = true;
            this.button_UnselectAll.Click += new System.EventHandler(this.button_UnselectAll_Click);
            // 
            // button_Install
            // 
            this.button_Install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Install.Location = new System.Drawing.Point(179, 228);
            this.button_Install.Name = "button_Install";
            this.button_Install.Size = new System.Drawing.Size(87, 29);
            this.button_Install.TabIndex = 5;
            this.button_Install.Text = "インストール";
            this.button_Install.UseVisualStyleBackColor = true;
            this.button_Install.Click += new System.EventHandler(this.button_Install_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(272, 228);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(87, 29);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // InstallFontWindow
            // 
            this.AcceptButton = this.button_Install;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(371, 269);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Install);
            this.Controls.Add(this.button_UnselectAll);
            this.Controls.Add(this.button_SelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallFontWindow";
            this.Text = "フォントをインストール";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SelectAll;
        private System.Windows.Forms.Button button_UnselectAll;
        private System.Windows.Forms.Button button_Install;
        private System.Windows.Forms.Button button_Cancel;
    }
}