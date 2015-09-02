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

namespace ClothUI.stuffManager._3
{
    public partial class StatisticMgr : Form
    {
        public StatisticMgr()
        {
            InitializeComponent();
        }

        private void StatisticMgr_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("身份证",100,HorizontalAlignment.Center);
            list_data.Columns.Add("姓名", 100,HorizontalAlignment.Center);
            list_data.Columns.Add("基本工资", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("提成", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("销量", 100,HorizontalAlignment.Center);
            list_data.Columns.Add("总工资", 100, HorizontalAlignment.Center);

            int year = DateTime.Now.Year;
            cbx_year.Items.Add(year);
            cbx_year.Items.Add(year - 1);
            cbx_year.Items.Add(year - 2);

            for (int i = 1; i <= 12; i++)
            {
                cbx_month.Items.Add(i);
            }
            cbx_month.SelectedIndex = DateTime.Now.Month - 1;
            cbx_year.SelectedIndex = 0;

            addItem("",DateTime.Now.Year,DateTime.Now.Month);
        }

        private void addItem(string name,int year,int month)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            PersonDAL pd = new PersonDAL();
            Person [] persons;
            if(name == "")
            {
                persons = pd.SearchByLimit(PERSONLIMIT.saleperson);
            }
            else
            {
                persons = pd.SearchByName(name);
            }

            foreach(Person person in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = person.ID;
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.Salary.ToString());
                float tc = sd.GetTheMonthTicheng(person.ID, year, month);
                item.SubItems.Add(tc.ToString());
                float total = tc + person.Salary;
                int count = sd.GetTheSoldNumber(person.ID, year, month);
                item.SubItems.Add(count.ToString());
                item.SubItems.Add(total.ToString());
                list_data.Items.Add(item);
            }
        }

        private void btn_saleDetail_Click(object sender, EventArgs e)
        {
            if (list_data.SelectedItems.Count == 0)
                return;
            SaleDetail saleDetail = new SaleDetail();
            saleDetail.ID = list_data.SelectedItems[0].Text;
            saleDetail.year = int.Parse(cbx_year.Text);
            saleDetail.month = int.Parse(cbx_month.Text);
            saleDetail.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            addItem(txt_search.Text, int.Parse(cbx_year.Text), int.Parse(cbx_month.Text));
        }
    }
}
