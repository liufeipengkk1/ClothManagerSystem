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

namespace ClothUI.clothManager
{
    public partial class SaleSituation : Form
    {
        private CClothDAL cd = new CClothDAL();
        public SaleSituation()
        {
            InitializeComponent();
        }

        private void SaleSituation_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("条纹码", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("品名", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("款式", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("颜色", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("尺码", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("原价", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("销售价格", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("销售人", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("销售时间", 100, HorizontalAlignment.Center);

           
            //最后一行
            ListViewItem item = new ListViewItem();
            item.SubItems[0].Text = "数据统计";
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("0");
            
            item.SubItems.Add("");
            item.SubItems.Add("");

            list_data.Items.Add(item);
            list_data.Items[0].ForeColor = Color.Red;

            addItem(cd.SearchByState(SALESTATE.sold));
            list_data.Items[list_data.Items.Count-1].SubItems[6].Text = Cal().ToString();

        }

        private void addItem(Cloth [] clothes)
        {
            if (clothes == null)
                return;
            SaleSheetDAL sd = new SaleSheetDAL();
            foreach (Cloth cloth in clothes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cloth.ID;
                item.SubItems.Add(cloth.Name);
                item.SubItems.Add(cloth.Style);
                item.SubItems.Add(cloth.Color);
                item.SubItems.Add(cloth.Size);
                item.SubItems.Add(cloth.Price.ToString());
                item.SubItems.Add(cloth.SalePrice.ToString());
                Person person = sd.GetThePerson(cloth.ID);
                item.SubItems.Add(person.Name);
                item.SubItems.Add(sd.GetTheSoldDateTime(cloth.ID).ToString("yyyy/MM/dd"));
                list_data.Items.Insert(list_data.Items.Count, item);
            }
        }

        private float Cal()
        {
            float result = 0 ;
            foreach(ListViewItem item in list_data.Items)
            {
                result += float.Parse(item.SubItems[6].Text);
            }
            return result;
        }

        private void ItemsClear()
        {
            int count = list_data.Items.Count;
            foreach(ListViewItem item in list_data.Items)
            {
                if (item.Text != "数据统计")
                    list_data.Items.Remove(item);
            }

            list_data.Items[list_data.Items.Count - 1].SubItems[6].Text = "0";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ItemsClear();
            SaleSheetDAL sd = new SaleSheetDAL();
            DateTime start = DateTime.Parse(dateTimePicker_start.Text);
            DateTime end = DateTime.Parse(dateTimePicker_end.Text);
            Cloth[] clothes = sd.ListSoldCloth(start, end);
            addItem(clothes);
            list_data.Items[list_data.Items.Count - 1].SubItems[6].Text = Cal().ToString();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            ItemsClear();
            SaleSheetDAL sd = new SaleSheetDAL();
            DateTime start = DateTime.Parse(dateTimePicker_start.Text);
            DateTime end = DateTime.Parse(dateTimePicker_end.Text);
            Cloth[] clothes = sd.ListSoldCloth();
            addItem(clothes);
            list_data.Items[list_data.Items.Count - 1].SubItems[6].Text = Cal().ToString();
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            SaleChart sc = new SaleChart();
            sc.ShowDialog();
        }
    }
}
