using System;
using System.Windows.Forms;
using MarketAnalyzer.Forms;

namespace MarketAnalyzer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.Instance.StartUp().GetAwaiter().GetResult();
            Application.Run(new MainForm());
        }
    }
}
