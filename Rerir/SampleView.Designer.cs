namespace Rerir
{
    partial class SampleView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.button_Install = new System.Windows.Forms.Button();
            this.button_FontSizeSmaller = new System.Windows.Forms.Button();
            this.button_FontSizeLarger = new System.Windows.Forms.Button();
            this.textBox_SampleText = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.propertyGrid);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.button_Install);
            this.splitContainer.Panel2.Controls.Add(this.button_FontSizeSmaller);
            this.splitContainer.Panel2.Controls.Add(this.button_FontSizeLarger);
            this.splitContainer.Panel2.Controls.Add(this.textBox_SampleText);
            this.splitContainer.Size = new System.Drawing.Size(491, 338);
            this.splitContainer.SplitterDistance = 112;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 2;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.propertyGrid.Size = new System.Drawing.Size(491, 112);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // button_Install
            // 
            this.button_Install.BackgroundImage = global::Rerir.Properties.Resources.Install;
            this.button_Install.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Install.Location = new System.Drawing.Point(3, 0);
            this.button_Install.Name = "button_Install";
            this.button_Install.Size = new System.Drawing.Size(30, 30);
            this.button_Install.TabIndex = 0;
            this.toolTip.SetToolTip(this.button_Install, "インストール");
            this.button_Install.UseVisualStyleBackColor = true;
            this.button_Install.Click += new System.EventHandler(this.button_Install_Click);
            // 
            // button_FontSizeSmaller
            // 
            this.button_FontSizeSmaller.BackgroundImage = global::Rerir.Properties.Resources.ZoomOut;
            this.button_FontSizeSmaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_FontSizeSmaller.Location = new System.Drawing.Point(75, 0);
            this.button_FontSizeSmaller.Name = "button_FontSizeSmaller";
            this.button_FontSizeSmaller.Size = new System.Drawing.Size(30, 30);
            this.button_FontSizeSmaller.TabIndex = 2;
            this.toolTip.SetToolTip(this.button_FontSizeSmaller, "縮小");
            this.button_FontSizeSmaller.UseVisualStyleBackColor = true;
            this.button_FontSizeSmaller.Click += new System.EventHandler(this.button_FontSizeSmaller_Click);
            // 
            // button_FontSizeLarger
            // 
            this.button_FontSizeLarger.BackgroundImage = global::Rerir.Properties.Resources.ZoomIn;
            this.button_FontSizeLarger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_FontSizeLarger.Location = new System.Drawing.Point(39, 0);
            this.button_FontSizeLarger.Name = "button_FontSizeLarger";
            this.button_FontSizeLarger.Size = new System.Drawing.Size(30, 30);
            this.button_FontSizeLarger.TabIndex = 1;
            this.toolTip.SetToolTip(this.button_FontSizeLarger, "拡大");
            this.button_FontSizeLarger.UseVisualStyleBackColor = true;
            this.button_FontSizeLarger.Click += new System.EventHandler(this.button_FontSizeLarger_Click);
            // 
            // textBox_SampleText
            // 
            this.textBox_SampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SampleText.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_SampleText.Location = new System.Drawing.Point(0, 32);
            this.textBox_SampleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SampleText.Multiline = true;
            this.textBox_SampleText.Name = "textBox_SampleText";
            this.textBox_SampleText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_SampleText.Size = new System.Drawing.Size(491, 188);
            this.textBox_SampleText.TabIndex = 3;
            this.textBox_SampleText.WordWrap = false;
            // 
            // SampleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SampleView";
            this.Size = new System.Drawing.Size(491, 338);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.TextBox textBox_SampleText;
        private System.Windows.Forms.Button button_FontSizeSmaller;
        private System.Windows.Forms.Button button_FontSizeLarger;
        private System.Windows.Forms.Button button_Install;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
