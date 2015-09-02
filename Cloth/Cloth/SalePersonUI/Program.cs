using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePersonUI
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
            Login login = new Login();
            login.ShowDialog();
            if(login.State)
            {
                Sale sale = new Sale();
                sale.SetID(login.ID);
                Application.Run(sale);
            }
            
        }
    }
}
