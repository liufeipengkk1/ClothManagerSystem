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
    public partial class SaleDetail : Form
    {
        public string ID { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public SaleDetail()
        {
            InitializeComponent();
        }

        private void SaleDetail_Load(object sender, EventArgs e)
        {

            list_data.Columns.Add("条纹码", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("品牌", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("款式", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("颜色", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("销售日期", 100, HorizontalAlignment.Center);

            cbo_year.Items.Add(DateTime.Now.Year);
            cbo_year.Items.Add(DateTime.Now.Year - 1);
            cbo_year.Items.Add(DateTime.Now.Year - 2);
            for (int i = 1; i <= 12; i++)
            {
                cbo_month.Items.Add(i);
            }
            cbo_year.SelectedIndex = 0;
            cbo_month.SelectedIndex = DateTime.Now.Month - 1;

            addItem(ID, 0, 0);
        }

        public void addItem(string id,int year,int month)
        {
            
            SaleSheetDAL sd = new SaleSheetDAL();
            Cloth[] clothes;
            if(year == 0 || month == 0)
            {
                clothes = sd.ListTheCloth(ID);
            }
            else
            {
                clothes = sd.ListTheCloth(id, year, month);
             }
            if (clothes == null)
                return;
            foreach(Cloth cloth in clothes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cloth.ID;
                item.SubItems.Add(cloth.Name);
                item.SubItems.Add(cloth.Style);
                item.SubItems.Add(cloth.Color);
                item.SubItems.Add(sd.GetTheSoldDateTime(cloth.ID).ToString("yyyy/MM/dd"));
                list_data.Items.Add(item);
            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            addItem(ID, 0, 0);
        }

        private void btn_week_Click(object sender, EventArgs e)
        {

        }

        private void btn_month_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            addItem(ID, DateTime.Now.Year, DateTime.Now.Month);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            addItem(ID, int.Parse(cbo_year.Text), int.Parse(cbo_month.Text));
        }
    }
}
