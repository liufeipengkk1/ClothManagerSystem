using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    public partial class adminManagerUI : Form
    {
        public adminManagerUI()
        {
            InitializeComponent();
        }

        private void adminManagerUI_Load(object sender, EventArgs e)
        {
            personMgUI pmg = new personMgUI();
            pmg.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pmg.TopLevel = false;
            this.panel_detail.Controls.Add(pmg);
            pmg.Show();
        }
    }
}
