using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vMixStatusGetter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// This application is made by Meriç Uçar, 500801785, IC103
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vMixStatus());
        }
    }
}
