using System;
using System.Windows.Forms;

namespace Rerir
{
    public partial class OptionWindow : Form
    {
        public OptionWindow()
        {
            InitializeComponent();

            this.numericUpDown_PreviewFontSize.Value = ConfigStore.DefaultPreviewFontSize;
            this.textBox_SampleText.Text = ConfigStore.DefaultSampleText;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Config Config
        {
            get
            {
                return new Config()
                {
                    DefaultPreviewFontSize = (int)this.numericUpDown_PreviewFontSize.Value,
                    DefaultSampleText = this.textBox_SampleText.Text
                };
            }
        }
    }
}
