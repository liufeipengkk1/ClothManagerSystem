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
    public partial class Alterpaswd : Form
    {
        public String ID { get; set; }

        public Alterpaswd()
        {
            InitializeComponent();
        }

        private void Alterpaswd_Load(object sender, EventArgs e)
        {
            lbl_ok.Hide();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_newpd.Text != txt_finalpd.Text)
            {
                lbl_ok.Text = "两次密码不一样";
                lbl_ok.Show();
                return;
            }
            PersonDAL pd = new PersonDAL();
            if( pd.AlterPasswd(ID,txt_oldpd.Text,txt_finalpd.Text) != 1)
            {
                lbl_ok.Text = "原密码错误，修改失败";
                lbl_ok.Show();
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
