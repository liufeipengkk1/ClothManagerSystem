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

namespace ClothUI.clothManager
{
    public partial class SaleChart : Form
    {
        private Statistic st = new Statistic();
        SaleSheetDAL sd = new SaleSheetDAL();

        public SaleChart()
        {
            InitializeComponent();
        }

        private void SaleChart_Load(object sender, EventArgs e)
        {
            cbo_year.DataSource = sd.ListSaleYear();
            cbo_year.ValueMember = "year";
            cbo_year.DisplayMember = "year";

            chart.Series[0].Name = cbo_year.Text + "年销售额曲线图（月）";
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            btn_money.PerformClick();
        }

        private void btn_monry_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cbo_year.Text);
            chart.DataSource = st.GetMonthSoldMoney(year);
            chart.Series[0].XValueMember = "月份";
            chart.Series[0].YValueMembers = "销售额";
            chart.DataBind();
        }

        private void btn_number_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cbo_year.Text);
            chart.DataSource = st.GetMonthSoldNumber(year);
            chart.Series[0].XValueMember = "月份";
            chart.Series[0].YValueMembers = "销量";
            chart.DataBind();
        }

    }
}
