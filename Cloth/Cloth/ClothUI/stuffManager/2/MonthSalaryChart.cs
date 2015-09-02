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

namespace ClothUI.stuffManager._2
{
    public partial class MonthSalaryChart : Form
    {
        public String ID { get; set; }
        private Statistic st = new Statistic();
        private PersonDAL pd = new PersonDAL();
        public MonthSalaryChart()
        {
            InitializeComponent();
        }

        private void MonthSalaryChart_Load(object sender, EventArgs e)
        {
            Person person = pd.SearchById(ID);
            this.Text = person.Name + "---月工资分布曲线图";
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            //
            cbo_year.Items.Add(DateTime.Now.Year);
            cbo_year.Items.Add(DateTime.Now.Year - 1);
            cbo_year.Items.Add(DateTime.Now.Year - 2);
            cbo_year.SelectedIndex = 0;
            BindDataSource(ID,DateTime.Now.Year);
        }

        private void BindDataSource(string id,int year)
        {
            DataTable baseSalary = st.GetPersonSalaryList(id, year);
            DataTable tc = st.GetPersonTiChengList(id, year);
            DataTable total = st.GetPersonTotalSalaryList(id, year);

            chart.Series[0].Points.DataBind(baseSalary.AsEnumerable(), "月份", "工资", "");
            chart.Series[1].Points.DataBind(tc.AsEnumerable(), "月份", "提成", "");
            chart.Series[2].Points.DataBind(total.AsEnumerable(), "月份", "总工资", "");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cbo_year.Text);
            BindDataSource(ID,year);
        }
    }
}
