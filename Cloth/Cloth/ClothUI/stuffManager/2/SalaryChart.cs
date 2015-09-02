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

namespace ClothUI.stuffManager._2
{
    public partial class SalaryChart : Form
    {
        private Statistic st = new Statistic() ; 
        public SalaryChart()
        {
            InitializeComponent();
        }

        private void SalaryChart_Load(object sender, EventArgs e)
        {
            this.Text = "员工工资分布曲线图";
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            //
            cbo_year.Items.Add(DateTime.Now.Year);
            cbo_year.Items.Add(DateTime.Now.Year-1);
            cbo_year.Items.Add(DateTime.Now.Year-2);

            for(int i = 1;i <= 12 ;i++)
            {
                cbo_month.Items.Add(i);
            }
            cbo_year.SelectedIndex = 0;
            cbo_month.SelectedIndex = DateTime.Now.Month - 1;
            
            BindDataSource(DateTime.Now.Year,DateTime.Now.Month);
        }
        /// <summary>
        /// 表： 
        ///   身份证 | 姓名 | 基本工资 | 提成 | 总工资
        /// </summary>
        private void BindDataSource(int year,int month)
        {
            DataTable dt = st.GetDetailSalary(year, month);
            
            chart.DataSource = dt;
            chart.ChartAreas[0].AxisX.Name = "员工姓名";
            chart.Series[0].XValueMember = "姓名";
            chart.Series[0].YValueMembers = "基本工资";

            chart.Series[1].XValueMember = "姓名";
            chart.Series[1].YValueMembers = "提成";

            chart.Series[2].XValueMember = "姓名";
            chart.Series[2].YValueMembers = "总工资";
            chart.DataBind();

            //DataTable dt = st.GetSalaryList(year, month);
            //chart.Series[0].Points.DataBind(dt.AsEnumerable(),"姓名","基本工资","");
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cbo_year.Text);
            int month = int.Parse(cbo_month.Text);

            BindDataSource(year,month);
        }
    }
}
