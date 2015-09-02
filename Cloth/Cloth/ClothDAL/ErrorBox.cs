using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothDAL
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
        }

        private void ErrorBox_Load(object sender, EventArgs e)
        {
            lbl_errorMsg.Text = ""; 
        }

        public String ErrorMsg 
        {
            get 
            {
                return lbl_errorMsg.Text;
            }
            set
            {
                lbl_errorMsg.Text = value;
            }
        }
    }
}
