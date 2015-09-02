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
    public partial class SalaryMgr : Form
    {
        public SalaryMgr()
        {
            InitializeComponent();
        }

        private void SalaryMgr_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("身份证", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("姓名", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("职务", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("基本工资", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("总提成", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("最终工资", 100, HorizontalAlignment.Left);


            int year = DateTime.Now.Year;
            cbx_year.Items.Add(year);
            cbx_year.Items.Add(year-1);
            cbx_year.Items.Add(year - 2);

            for(int i = 1 ;i <=12;i++)
            {
                cbx_month.Items.Add(i);
            }
            cbx_month.SelectedIndex = DateTime.Now.Month-1;
            cbx_year.SelectedIndex = 0;

            AddItem("", DateTime.Now.Year, DateTime.Now.Month);
        }

        private void AddItem(string name,int year,int month)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            PersonDAL pd = new PersonDAL();
            Person[] persons;
            if (name == "")
            {
                persons = pd.ListAll();
            }
            else
            {
                persons = pd.SearchByName(name);
            }

            foreach (Person person in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = person.ID;
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.Office);
                item.SubItems.Add(person.Salary.ToString());
                float tc = sd.GetTheMonthTicheng(person.ID, year, month);
                item.SubItems.Add(tc.ToString());
                float total = tc + person.Salary;
                item.SubItems.Add(total.ToString());
                list_data.Items.Add(item);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            AddItem(txt_search.Text,int.Parse(cbx_year.Text),int.Parse(cbx_month.Text));
        }

        private void ToolStripMenuItem_Alter_Click(object sender, EventArgs e)
        {
            if(list_data.SelectedItems.Count != 0)
            {
                ListViewItem item = list_data.SelectedItems[0];
                MAlterSalary ma = new MAlterSalary();
                AlterSalary a = new AlterSalary();
                
                a.Name = item.SubItems[1].Text;
                a.oldSalary = item.SubItems[3].Text;
                a.ShowDialog();
                if (a.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    PersonDAL pd = new PersonDAL();
                    AlterSalaryDAL asd = new AlterSalaryDAL();
                    if (pd.AlterSalary(item.Text, a.Salary) == -1 )
                    {
                        MessageBox.Show("修改失败");
                    }
                    else
                    {
                        ma.ID = item.Text;
                        ma.PersonName = item.SubItems[1].Text;
                        ma.OldSalary = float.Parse(item.SubItems[3].Text);
                        ma.NewSalary = a.Salary;
                        ma.Reason = a.Reason;
                        ma.Time = DateTime.Now;
                        asd.Insert(ma);
                        item.SubItems[3].Text = a.Salary.ToString();
                    }
                }
            }
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            SalaryChart sc = new SalaryChart();
            sc.ShowDialog();
        }

        private void ToolStripMenuItem_Chart_Click(object sender, EventArgs e)
        {
            if(list_data.SelectedItems.Count != 0)
            {
                ListViewItem item = list_data.SelectedItems[0];
                MonthSalaryChart mc = new MonthSalaryChart();
                mc.ID = item.Text;
                mc.ShowDialog();
            }
            
            
        }
    }
}
