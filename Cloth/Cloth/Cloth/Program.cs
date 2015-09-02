using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            admin ad = new admin() ;
            ad.ShowDialog();
            if (ad.LoginState)
            {
                
                Application.Run(new adminManagerUI());
            }
            
        }
    }
}
