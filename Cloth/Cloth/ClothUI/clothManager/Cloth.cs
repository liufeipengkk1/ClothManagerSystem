using ClothDAL;
using ClothModel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
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
    public partial class UCloth : Form
    {
        public UCloth()
        {
            InitializeComponent();
        }

        private void Cloth_Load(object sender, EventArgs e)
        {
            list_cloth.Columns.Add("条纹码", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("名称", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("款式", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("尺码", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("颜色", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("原价", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("出售价", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("提成", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("销售状态", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("进货时间", 100, HorizontalAlignment.Center);
            list_cloth.Columns.Add("销售时间", 100, HorizontalAlignment.Center);

            //cbx_style.DataSource = StyleTable();
            //cbx_style.DisplayMember = "style";
            //cbx_style.Text = "123";
            DataRowCollection rows = StyleTable().Rows;
            int count = rows.Count;
            cbx_style.Items.Add("款式");
            for (int i = 0; i < count;i++ )
            {
                cbx_style.Items.Add(rows[i]["style"]);
            }

            rows = SizeTable().Rows;
            count = rows.Count;
            cbx_size.Items.Add("尺寸");
            for (int i = 0; i < count; i++)
            {
                cbx_size.Items.Add(rows[i]["size"]);
            }

            rows = ColorTable().Rows;
            count = rows.Count;
            cbx_color.Items.Add("颜色");
            for (int i = 0; i < count; i++)
            {
                cbx_color.Items.Add(rows[i]["color"]);
            }

            rows = ImportTimeTable().Rows;
            count = rows.Count;
            cbx_time.Items.Add("进货时间");
            for (int i = 0; i < count; i++)
            {
                cbx_time.Items.Add(rows[i]["importtime"]);
            }

            cbx_saleState.Items.Add("所有");
            cbx_saleState.Items.Add("在售");
            cbx_saleState.Items.Add("已售");
            cbx_saleState.Items.Add("下架");
            cbx_saleState.Items.Add("仓库");

            addItem("");
        }

        private DataTable StyleTable()
        {
            CClothDAL cd = new CClothDAL();
            return cd.ListAllStyle();
        }

        private DataTable SizeTable()
        {
            CClothDAL cd = new CClothDAL();
            return cd.ListAllSize();
        }

        private DataTable ColorTable()
        {
            CClothDAL cd = new CClothDAL();
            return cd.ListAllColor();
        }

        private DataTable ImportTimeTable()
        {
            CClothDAL cd = new CClothDAL();
            return cd.ListImportTime();
        }

        private void BindClothes(Cloth [] clothes)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            foreach (Cloth cloth in clothes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = cloth.ID;
                item.SubItems.Add(cloth.Name);
                item.SubItems.Add(cloth.Style);
                item.SubItems.Add(cloth.Size);
                item.SubItems.Add(cloth.Color);
                item.SubItems.Add(cloth.Price.ToString());
                item.SubItems.Add(cloth.SalePrice.ToString());
                float tc = sd.GetTheClothTiCheng(cloth.ID);
                item.SubItems.Add(tc.ToString());
                item.SubItems.Add(cloth.SaleState);
                item.SubItems.Add(cloth.ImportTime.ToString("yyyy/MM/dd"));

                DateTime dt = sd.GetTheSoldDateTime(cloth.ID);
                if(dt.Year != 1)
                    item.SubItems.Add(dt.ToString("yyyy/MM/dd"));
                list_cloth.Items.Add(item);
                if(cloth.SaleState == SALESTATE.onsale)
                    item.ForeColor = Color.Red;
            }
        }

        private void addItem(string id)
        {
            CClothDAL cd = new CClothDAL();
            SaleSheetDAL sd = new SaleSheetDAL();
            Cloth[] clothes;
            if(id == "")
            {
                clothes = cd.ListAll();
                foreach (Cloth cloth in clothes)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = cloth.ID;
                    item.SubItems.Add(cloth.Name);
                    item.SubItems.Add(cloth.Style);
                    item.SubItems.Add(cloth.Size);
                    item.SubItems.Add(cloth.Color);
                    item.SubItems.Add(cloth.Price.ToString());
                    item.SubItems.Add(cloth.SalePrice.ToString());
                    float tc = sd.GetTheClothTiCheng(cloth.ID);
                    item.SubItems.Add(tc.ToString());
                    item.SubItems.Add(cloth.SaleState);
                    item.SubItems.Add(cloth.ImportTime.ToString("yyyy/MM/dd"));

                    DateTime dt = sd.GetTheSoldDateTime(cloth.ID);
                    if (dt.Year != 1)
                        item.SubItems.Add(dt.ToString("yyyy/MM/dd"));

                    list_cloth.Items.Add(item);
                    if (cloth.SaleState == SALESTATE.onsale)
                        item.ForeColor = Color.Red;
                }
            }
            else
            {
                Cloth cloth = cd.SearchById(id);
                ListViewItem item = new ListViewItem();
                item.Text = cloth.ID;
                item.SubItems.Add(cloth.Name);
                item.SubItems.Add(cloth.Style);
                item.SubItems.Add(cloth.Size);
                item.SubItems.Add(cloth.Color);
                item.SubItems.Add(cloth.Price.ToString());
                item.SubItems.Add(cloth.SalePrice.ToString());
                float tc = sd.GetTheClothTiCheng(cloth.ID);
                item.SubItems.Add(tc.ToString());
                item.SubItems.Add(cloth.SaleState);
                item.SubItems.Add(cloth.ImportTime.ToString("yyyy/MM/dd"));

                DateTime dt = sd.GetTheSoldDateTime(cloth.ID);
                if (dt.Year != 1)
                    item.SubItems.Add(dt.ToString("yyyy/MM/dd"));

                list_cloth.Items.Add(item);
                if (cloth.SaleState == SALESTATE.onsale)
                    item.ForeColor = Color.Red;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int count = list_cloth.CheckedItems.Count;
            if (count == 0)
                return;

            CClothDAL cd = new CClothDAL();
            SaleSheetDAL ssd = new SaleSheetDAL();
            ActivityDAL ad = new ActivityDAL();
            
            String countString = count.ToString();
            if (MessageBox.Show("是否要删除这" + countString + "项") == System.Windows.Forms.DialogResult.OK)
            {
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    //删除活动中的这件商品 删除销售记录
                    cd.DeleteClothById(item.Text);
                    ad.DeleteClothFromActivity(item.Text);
                    ssd.Delete(item.Text);
                    item.Remove();
                }
            }

            list_cloth.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list_cloth.Items.Clear();
            addItem(txt_search.Text);
        }

        private void cbx_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if (cbx_style.SelectedIndex == 0)
            {
                list_cloth.Items.Clear();
                addItem("");
            }
            else
            {
                Cloth [] clothes = cd.SearchByStyle(cbx_style.Text);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
        }

        private void cbx_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if (cbx_size.SelectedIndex == 0)
            {
                list_cloth.Items.Clear();
                addItem("");
            }
            else
            {
                Cloth[] clothes = cd.SearchBySize(cbx_size.Text);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
        }

        private void cbx_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if (cbx_color.SelectedIndex == 0)
            {
                list_cloth.Items.Clear();
                addItem("");
            }
            else
            {
                Cloth[] clothes = cd.SearchByColor(cbx_color.Text);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
        }

        private void cbx_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if (cbx_time.SelectedIndex == 0)
            {
                list_cloth.Items.Clear();
                addItem("");
            }
            else
            {
                DateTime dt = Convert.ToDateTime(cbx_time.Text);
                Cloth[] clothes = cd.ListImportCloth(dt.Year, dt.Month, dt.Day, null);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
        }

        private void cbx_saleState_SelectedIndexChanged(object sender, EventArgs e)
        {
            CClothDAL cd = new CClothDAL();
            if(cbx_saleState.Text == "所有")
            {
                list_cloth.Items.Clear();
                addItem("");
            }
            else if(cbx_saleState.Text == "在售")
            {
                Cloth[] clothes = cd.ListSaleStateCloth(SALESTATE.onsale);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
            else if (cbx_saleState.Text == "已售")
            {
                Cloth[] clothes = cd.ListSaleStateCloth(SALESTATE.sold);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
            else if (cbx_saleState.Text == "下架")
            {
                Cloth[] clothes = cd.ListSaleStateCloth(SALESTATE.offshalves);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
            else if (cbx_saleState.Text == "仓库")
            {
                Cloth[] clothes = cd.ListSaleStateCloth(SALESTATE.warehouse);
                list_cloth.Items.Clear();
                BindClothes(clothes);
            }
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(list_cloth.CheckedItems.Count != 0)
            {
                foreach(ListViewItem item in list_cloth.CheckedItems)
                {
                    if(item.SubItems[8].Text == "sold")
                    {
                        item.Checked = false;
                    }
                }

                CClothDAL cd = new CClothDAL();
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    item.SubItems[8].Text = SALESTATE.warehouse;
                    cd.AlterSaleState(item.Text,SALESTATE.warehouse);
                }
            }
        }

        private void onsaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_cloth.CheckedItems.Count != 0)
            {
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    if (item.SubItems[8].Text == "onsale")
                    {
                        item.Checked = false;
                    }
                }

                CClothDAL cd = new CClothDAL();
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    item.SubItems[8].Text = SALESTATE.onsale;
                    cd.AlterSaleState(item.Text, SALESTATE.onsale);
                }
            }
        }

        private void offshalvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list_cloth.CheckedItems.Count != 0)
            {
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    if (item.SubItems[8].Text == "sold")
                    {
                        item.Checked = false;
                    }
                }

                CClothDAL cd = new CClothDAL();
                foreach (ListViewItem item in list_cloth.CheckedItems)
                {
                    item.SubItems[8].Text = SALESTATE.offshalves;
                    cd.AlterSaleState(item.Text, SALESTATE.offshalves);
                }
            }
        }

        private void ToolStripMenuItem_export_Click(object sender, EventArgs e)
        {
            if (list_cloth.CheckedItems.Count != 0)
            {
                SaveFileDialog sp = new SaveFileDialog();
                sp.Filter = "xls文件|*.xls;*.xlsx";
                sp.Title = "导出清单";
                if (sp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String fileName = sp.FileName;
                    FileInfo newFile = new FileInfo(fileName);
                    if (newFile.Exists)
                    {
                        if (MessageBox.Show("文件已经存在，是否要替换") == System.Windows.Forms.DialogResult.OK)
                        {
                            newFile.Delete();  // ensures we create a new workbook
                        }
                    }
                    newFile = new FileInfo(fileName);
                    using (ExcelPackage package = new ExcelPackage(newFile))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("服装清单");
                        worksheet.Cells[1, 1].Value = "条纹码";
                        worksheet.Cells[1, 2].Value = "品牌";
                        worksheet.Cells[1, 3].Value = "款式";
                        worksheet.Cells[1, 4].Value = "尺码";
                        worksheet.Cells[1, 5].Value = "颜色";
                        
                        //add the items
                        int row = 2;
                        int col = 1;
                        int rowCount = list_cloth.CheckedItems.Count;
                        for (row = 0; row < rowCount; row++)
                        {
                            for (col = 0; col < 5; col++)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = list_cloth.CheckedItems[row].SubItems[col].Text;
                            }
                        }
                        //  worksheet.Cells["A1:K11"].Style.Font.Color.SetColor(Color.Red);
                        package.Save();
                    }
                }
            }
        }

        
    }
}
