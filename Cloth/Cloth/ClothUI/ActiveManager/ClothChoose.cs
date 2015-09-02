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

namespace ClothUI.ActiveManager
{
    public partial class ClothChoose : Form
    {
        public List<string> ClothID = new List<string>();
        public ClothChoose()
        {
            InitializeComponent();
        }

        private void ClothChoose_Load(object sender, EventArgs e)
        {
            list_data.Columns.Add("条纹码", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("品牌", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("款式", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("颜色", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("尺寸", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("上架时间", 100, HorizontalAlignment.Center);
            list_data.Columns.Add("原价", 100, HorizontalAlignment.Center);

            DataRowCollection rows = ImportTimeTable().Rows;
            int count = rows.Count;
            cbx_time.Items.Add("进货时间");
            for (int i = 0; i < count; i++)
            {
                cbx_time.Items.Add(rows[i]["importtime"]);
            }

            addItem(null);
        }

        private DataTable ImportTimeTable()
        {
            CClothDAL cd = new CClothDAL();
            return cd.ListImportTime();
        }

        private void addItem(String salestate)
        {
            Cloth[] clothes;
            CClothDAL cd = new CClothDAL();
            if(salestate == null)
                clothes = cd.ListSaleStateCloth(SALESTATE.onsale);
            else
                clothes = cd.ListSaleStateCloth(salestate);

            if(clothes != null)
            {
                foreach (Cloth cloth in clothes)
                    BindItem(cloth);
            }
        }

        private void BindItem(Cloth cloth)
        {
            ListViewItem item = new ListViewItem();
            item.Text = cloth.ID;
            item.SubItems.Add(cloth.Name);
            item.SubItems.Add(cloth.Style);
            item.SubItems.Add(cloth.Color);
            item.SubItems.Add(cloth.Size);
            item.SubItems.Add(cloth.ImportTime.ToString("yyyy/MM/dd"));
            item.SubItems.Add(cloth.Price.ToString());

            list_data.Items.Add(item);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int count = list_data.CheckedItems.Count;
            if(count == 0)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            else
            {
                for(int i = 0;i < count;i++)
                {
                    ClothID.Add(list_data.CheckedItems[i].Text);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void cbx_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if (cbx_time.SelectedIndex == 0)
            {
                list_data.Items.Clear();
                addItem(null);
            }
            else
            {
                DateTime dt = Convert.ToDateTime(cbx_time.Text);
                Cloth[] clothes = cd.ListImportCloth(dt.Year, dt.Month, dt.Day, null);
                list_data.Items.Clear();
                if(clothes != null)
                {
                    foreach(Cloth cloth in clothes)
                    {
                        if(cloth.SaleState != "sold")
                            BindItem(cloth);
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            Cloth cloth = cd.SearchById(txt_search.Text);
            if(cloth != null)
            {
                list_data.Items.Clear();
                BindItem(cloth);
            }
            
        }
    }
}
