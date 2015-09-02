using ClothUI.stuffManager;
using ClothUI.stuffManager._2;
using ClothUI.stuffManager._3;
using ClothUI.stuffManager._4;
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
    public partial class StuffMgr : Form
    {
        // 内部有三个form
        private Stuff stuff = new Stuff();
        private StatisticMgr statistic = new StatisticMgr();
        private SalaryMgr salary = new SalaryMgr(); 
        
        //初始化内部的form 这些form都放在内部的pal_right里头
        private void InitInnerPanelForm(Panel pal,params Form [] winds)
        {
            if(winds == null)
            {
                MessageBox.Show("界面异常");
                return ;
            }

            foreach(Form wind in winds)
            {
                wind.TopLevel = false;
                wind.ClientSize = new System.Drawing.Size(pal.Size.Width,pal.Size.Height);
                wind.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //填充整个panel
                wind.Dock = DockStyle.Fill;
                pal.Controls.Add(wind);
            }
        }

        public StuffMgr()
        {
            InitializeComponent();
            InitInnerPanelForm(pal_right, stuff, salary, statistic);
            stuff.Show();
            statistic.Hide();
            salary.Hide();
        }

        private void StuffMgr_Load(object sender, EventArgs e)
        {

        }
    
        private void btn_stuffMgr_Click(object sender, EventArgs e)
        {
            salary.Hide();
            statistic.Hide();
            stuff.Show();
        }

        private void btn_salaryMgr_Click(object sender, EventArgs e)
        {
            stuff.Hide();
            statistic.Hide();
            salary.Show();
        }

        private void btn_statisticMgr_Click(object sender, EventArgs e)
        {
            salary.Hide();
            stuff.Hide();
            statistic.Show();
        }


        private void btn_TiChengMentMgr_Click(object sender, EventArgs e)
        {
            TiChengMgr tc = new TiChengMgr();
            tc.ShowDialog();
        }
    }
}
