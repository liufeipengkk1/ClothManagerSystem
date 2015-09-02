using ClothDAL;
using ClothModel;
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
    public partial class Login : Form
    {
        public String ID { get; set; }
        private bool _LoginState;
        public bool loginState 
        {
            get
            {
                return _LoginState;
            }
            set
            {
                _LoginState = loginState;
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _LoginState = false;
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            PersonDAL personDal = new PersonDAL();
            if(!personDal.LoginVerufication(txt_userName.Text,txtPswd.Text,PERSONLIMIT.admin))
            {
                lbl_loginstate.Show();
                return;
            }

            ID = txt_userName.Text;
            _LoginState = true;
            lbl_loginstate.Text = "正在初始化系统环境....";
            AskForLeaveDAL afd = new AskForLeaveDAL();
            afd.CheckLeave();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_loginstate.Hide();
            if (!SqlHelper.TestLinkDatabase())
            {
                MessageBox.Show("检查是否联网，若网络正常则远程数据库异常，请联系服务人员");
                Application.Exit();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                btn_cancel.PerformClick();
            }
        }
    }
}
 ;