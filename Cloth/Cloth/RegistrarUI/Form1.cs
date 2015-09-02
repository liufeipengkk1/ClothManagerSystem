using ClothDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrarUI
{
    public partial class Login : Form
    {
        public String ID { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {
            lbl_loginInfo.Hide();
           if(!SqlHelper.TestLinkDatabase())
           {
               MessageBox.Show("检查是否联网，若网络正常则远程数据库异常，请联系服务人员");
               Application.Exit();
           }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PersonDAL personDal = new PersonDAL();
            ID = txt_Name.Text;

            //if the info is not matched , do nothing
            if (!personDal.LoginVerufication(ID, txt_passwd.Text, "registrar"))
            {
                lbl_loginInfo.Show();
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                btn_cancel.PerformClick();
        }
    }
}
