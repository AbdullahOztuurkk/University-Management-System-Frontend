using System;
using System.Windows.Forms;
using UniOtomasyonUI.Models;

namespace UniOtomasyonUI
{
    static class Program
    {
        public static string ACCESS_TOKEN = "";
        public static User CURRENT_USER;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
        }
    }
}
