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
    public partial class admin : Form
    {
        private bool _loginState = false;
        public bool LoginState 
        {
            get
            {
                return _loginState;
            }
            set
            {
                _loginState = value;
            }
        }

        public admin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginState = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
