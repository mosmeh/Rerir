using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Rerir
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<string> args;
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                args = new List<string>(Environment.GetCommandLineArgs());
                args.RemoveAt(0);
            }
            else
            {
                args = FontFileOpener.OpenFile();
            }

            if(args != null)
                Application.Run(new MainWindow(args));
        }
    }
}
