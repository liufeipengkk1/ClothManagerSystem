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

namespace SalePersonUI
{
    public partial class Login : Form
    {
        public String ID { get;set;}
        public bool State { get; set; }
        public Login()
        {
            InitializeComponent();
            State = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            PersonDAL personDal = new PersonDAL();
            ID = txt_name.Text;
            if(!personDal.LoginVerufication(txt_name.Text, txt_passwd.Text, "saleperson"))
            {
                lab_loginInfo.Show();
                State = false;
                return;
            }
            State = true;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lab_loginInfo.Hide();
            if(!SqlHelper.TestLinkDatabase())
            {
                MessageBox.Show("检查是否联网，若网络正常则远程数据库异常，请联系服务人员");
                Application.Exit();
            }
            
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ok.PerformClick();
            if (e.KeyCode == Keys.Escape)
                btn_cancel.PerformClick();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
