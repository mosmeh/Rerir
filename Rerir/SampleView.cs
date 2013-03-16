using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rerir
{
    public partial class SampleView : UserControl
    {
        public SampleView()
        {
            InitializeComponent();

            this.SampleText = ConfigStore.DefaultSampleText;
        }

        public Font ViewFont
        {
            get
            {
                return textBox_SampleText.Font;
            }

            set
            {
                this.textBox_SampleText.Font = value;
            }
        }

        public string SampleText
        {
            set
            {
                this.textBox_SampleText.Text = value;
            }
        }

        public FontInfo FontInfo
        {
            get
            {
                return (FontInfo)propertyGrid.SelectedObject;
            }

            set
            {
                this.propertyGrid.SelectedObject = value;
            }
        }

        private void AddToPreviewFontSize(int num)
        {
            var currentfont = this.textBox_SampleText.Font;
            this.textBox_SampleText.Font = FontStore.GetEnclosureByFamilyName(currentfont.FontFamily.Name).GetFont(currentfont.Size + num);
        }

        private void button_Install_Click(object sender, EventArgs e)
        {
            FontStore.GetEnclosureByFamilyName(this.Font.Name).Install();
        }

        private void button_FontSizeLarger_Click(object sender, EventArgs e)
        {
            AddToPreviewFontSize(1);
        }

        private void button_FontSizeSmaller_Click(object sender, EventArgs e)
        {
            AddToPreviewFontSize(-1);
        }
    }
}
