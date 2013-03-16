using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Rerir
{
    public partial class MainWindow : Form
    {
        public MainWindow(List<string> args)
        {
            InitializeComponent();
            ConfigStore.Load();
            args.ForEach(x => this.ViewFontInfo(x));
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigStore.Save();
        }

        private void ViewFontInfo(string path)
        {
            var fontecr = new FontEnclosure(path);
            FontStore.Add(fontecr);

            var tabpage = new TabPage(fontecr.GetFontInfo().Name);
            tabpage.Controls.Add(new SampleView()
            {
                Dock = DockStyle.Fill,
                ViewFont = fontecr.GetFont(),
                FontInfo = fontecr.GetFontInfo()
            });
            tabControl.TabPages.Add(tabpage);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count == 1)
                FontStore.GetEnclosureByFamilyName(tabControl.SelectedTab.Text).Install();
            else
            {
                var installfontwindow = new InstallFontWindow();
                if (installfontwindow.ShowDialog() == DialogResult.OK)
                {
                    installfontwindow.SelectedFonts.ForEach(x => FontStore.GetEnclosureByFamilyName(x).Install());
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var files = FontFileOpener.OpenFile();
            if(files != null)
                files.ForEach(x => this.ViewFontInfo(x));
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab.Dispose();
            if (tabControl.TabCount == 0)
                this.Close();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionwindow = new OptionWindow();
            if (optionwindow.ShowDialog() == DialogResult.OK)
            {
                ConfigStore.Update(optionwindow.Config);
            }
        }
    }
}
