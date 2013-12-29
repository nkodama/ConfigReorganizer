using System;
using System.Windows.Forms;

namespace ConfigReorganizer
{
    public static class ConfigReorganizer
    {
        /// <summary>
        /// バージョン文字列
        /// </summary>
        internal const string Version = "0.05";

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}