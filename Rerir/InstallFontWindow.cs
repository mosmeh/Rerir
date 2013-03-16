using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rerir
{
    public partial class InstallFontWindow : Form
    {
        public InstallFontWindow()
        {
            InitializeComponent();

            FontStore.GetFontEnclosures().ForEach(x => 
                checkedListBox.Items.Add(x.GetFont().FontFamily.Name));
        }

        public List<string> SelectedFonts
        {
            get
            {
                return this.checkedListBox.CheckedItems.OfType<string>().ToList();
            }
        }

        private void SetAllItemCheckState(bool check)
        {
            Enumerable.Range(0, checkedListBox.Items.Count).
                ToList().
                ForEach(x => 
                    checkedListBox.SetItemCheckState(x, check ? CheckState.Checked : CheckState.Unchecked));
        }

        private void button_SelectAll_Click(object sender, EventArgs e)
        {
            SetAllItemCheckState(true);
        }

        private void button_UnselectAll_Click(object sender, EventArgs e)
        {
            SetAllItemCheckState(false);
        }

        private void button_Install_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
