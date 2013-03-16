using System.Collections.Generic;
using System.Windows.Forms;

namespace Rerir
{
    public static class FontFileOpener
    {
        public static List<string> OpenFile()
        {
            var openfile = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "TrueType フォント|*.ttf|OpenType フォント|*.otf|フォント ファイル|*.ttf;*.otf",
                FilterIndex = 3,
                Title = "フォント ファイルを選択"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
                return new List<string>(openfile.FileNames);
            else
                return null;
        }
    }
}
