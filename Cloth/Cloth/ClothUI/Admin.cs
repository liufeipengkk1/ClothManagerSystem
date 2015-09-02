using ClothDAL;
using ClothModel;
using ClothUI.ActiveManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    public partial class Admin : Form
    {
        //const int WM_NCLBUTTONDOWN = 0x00A1;
        //const int HTCAPTION = 2;
        // 固定大小
        private int width = 0;
        private int height = 0 ;
        private string _ID;
        // 包含四大模块
        private StuffMgr stuffMgr = new StuffMgr();
        private ClothMgr clothMgr = new ClothMgr();
        private ActivityMgr activityMgr = new ActivityMgr();
        //初始化内部的form 这些form都放在内部的pal_right里头

        private Person person;

        private void InitInnerPanelForm(params Form[] winds)
        {
            if (winds == null)
            {
                MessageBox.Show("界面异常");
                return;
            }

            foreach (Form wind in winds)
            {
                wind.TopLevel = false;
                wind.ClientSize = new System.Drawing.Size(pal_mid.Size.Width, pal_mid.Size.Height);
                wind.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //填充整个panel
                wind.Dock = DockStyle.Fill;
                pal_mid.Controls.Add(wind);
            }

        }



        public Admin()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            //SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            InitInnerPanelForm(stuffMgr,clothMgr,activityMgr);
            stuffMgr.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            PersonDAL pd = new PersonDAL();
            if(_ID == "")
            {
                MessageBox.Show("异常结束");
                Application.Exit();
            }
            person = pd.SearchById(_ID);
            if(person.Limit == PERSONLIMIT.admin)
                lbl_bottom.Text = lbl_bottom.Text + " 管理员登陆：" + person.Name + "  F8 :更改密码";
            if (person.Photo != null)
            {
                MemoryStream stream = new MemoryStream(person.Photo);
                picture_Head.Image = Image.FromStream(stream);
            }
        }

        public void SetId(string id)
        {
            _ID = id;
        }

        private void btn_stuffMgr_Click(object sender, EventArgs e)
        {

            clothMgr.Hide();
            activityMgr.Hide();
            stuffMgr.Show();
        }

        private void Admin_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < width)
                this.Width = width;
            if (this.Height < height)
                this.Height = height;
            
        }

        private void btn_clothMgr_Click(object sender, EventArgs e)
        {
            stuffMgr.Hide();
            activityMgr.Hide();
            clothMgr.Show();
        }

        private void btn_activeMgr_Click(object sender, EventArgs e)
        {
            stuffMgr.Hide();
            clothMgr.Hide();
            activityMgr.Show();
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                Alterpaswd ap = new Alterpaswd();
                ap.ID = _ID;
                ap.ShowDialog();
            }
        }


 
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
        //        return;

        //    base.WndProc(ref m);
        //}
    }
}
