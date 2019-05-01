using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string arg = "";
            string num = "";
            if (args.Length == 0)
                arg = "/c";
            else
                arg = args[0].ToLower().Trim();

            if (arg.Length > 3)
            {
                num = arg.Substring(3);
                arg = arg.Substring(0, 2);
            }
            if (args.Length >= 2)
            {
                num = args[1];
            }
            if (arg == "/c")
            {
                Application.Run(new SettingsForm());
            }
            if(arg == "/s")
            {
                Application.Run(new SaverForm(Screen.PrimaryScreen.Bounds));
            }
            if (arg == "/p")
            {
                Application.Run(new SaverForm(num));
            }
        }
    }
}
