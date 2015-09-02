using ClothDAL;
using ClothModel;
using ClothUI.ActiveManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;


namespace ClothUI.clothManager
{
    public partial class AddActive : Form
    {

        public string FLAG { get; set; }    // Edit 、 Insert Watch
        public Activity activity { get; set; }
        private List<string> clothid = null;

        private int row = -1;
        public AddActive()
        {
            InitializeComponent();
        }

        private void AddActive_Load(object sender, EventArgs e)
        {
            if(FLAG == "Edit")
            {
                txt_activeID.Enabled = false;
                Bind();
            }
            else if(FLAG == "Watch")
            {
                txt_activeID.Enabled = false;
                dateTimePicker_end.Enabled = false;
                dateTimePicker_start.Enabled = false;
                txt_reason.Enabled = false;
                contextMenuStrip.Enabled = false;
                dataGrid_cloth.Enabled = false;
                btn_ok.Enabled = false;
                btn_choose.Enabled = false;
                Bind();
            }
        }

        private void Bind()
        {
            ActivityDAL ad = new ActivityDAL();
            txt_activeID.Text = activity.Name;
            dateTimePicker_start.Text = activity.StartTime.ToString("yyyy/MM/dd");
            dateTimePicker_end.Text = activity.EndTime.ToString("yyyy/MM/dd");
            txt_reason.Text = activity.ActivityContent;
            Cloth [] clothes = ad.ListActivityCloth(activity.Name);
            if(clothes != null)
            {
                foreach (Cloth cloth in clothes)
                {
                    AddItem(cloth);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (row == -1 || row == dataGrid_cloth.Rows.Count)
                return;
            dataGrid_cloth.Rows.RemoveAt(row);
            //dataGrid_cloth.Refresh();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            ClothChoose clothChoose = new ClothChoose();
            clothChoose.ShowDialog();
            clothid = clothChoose.ClothID;
            CClothDAL cd = new CClothDAL();
            foreach(string id in clothid)
            {
                Cloth cloth = cd.SearchById(id);
                AddItem(cloth);
            }
        }

        private void AddItem(Cloth cloth)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGrid_cloth);
            row.Cells[0].Value = cloth.ID;
            row.Cells[1].Value = cloth.Name;
            row.Cells[2].Value = cloth.Style;
            row.Cells[3].Value = cloth.Color;
            row.Cells[4].Value = cloth.Size;
            row.Cells[5].Value = cloth.Price;

            if (FLAG == "Edit" || FLAG == "Watch")
            {
                ActivityDAL ad = new ActivityDAL();
                row.Cells[6].Value = ad.GetTheActivitySalePrice(cloth.ID);
                if(ad.SaleInActivity(cloth.ID,activity.Name,activity.StartTime,activity.EndTime) == true)
                    row.Cells[6].Style.BackColor = Color.Red;
            }

            dataGrid_cloth.Rows.Add(row);
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(FLAG == "Watch")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
            ActivityDAL ad = new ActivityDAL();
            Activity ac = new Activity();
            ac.Name = txt_activeID.Text;
            ac.StartTime = Convert.ToDateTime(dateTimePicker_start.Text);
            ac.EndTime = Convert.ToDateTime(dateTimePicker_end.Text);
            ac.ActivityContent = txt_reason.Text;
            
            if(FLAG == "Edit")
            {
                ad.UpdateActivity(ac);
                ad.DeleteActivityCloth(ac.Name);
            }
            else
            {
                ad.Insert(ac);
            }

            int count = dataGrid_cloth.Rows.Count;
            if (count != 0)
            {
                for(int i = 0 ;i < count - 1;i++)
                {
                    float saleprice = Convert.ToSingle(dataGrid_cloth.Rows[i].Cells[6].Value);
                    String id = (string)dataGrid_cloth.Rows[i].Cells[0].Value;
                    ad.InsertClothToActivity(ac.Name, id,saleprice);
                }
            }

            activity = ac;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("进货清单");

                    //add header
                    worksheet.Cells[1, 1].Value = "条纹码";
                    worksheet.Cells[1, 2].Value = "品牌";
                    worksheet.Cells[1, 3].Value = "款式";
                    worksheet.Cells[1, 4].Value = "颜色";
                    worksheet.Cells[1, 5].Value = "尺码";
                    worksheet.Cells[1, 6].Value = "原售价";
                    worksheet.Cells[1, 6].Value = "活动售价";

                    //add the items
                    int row = 0;
                    int col = 0;
                    int clothCount = dataGrid_cloth.Rows.Count - 1;
                    for (row = 0; row < clothCount; row++)
                    {
                        for (col = 0; col < 6; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGrid_cloth.Rows[row].Cells[col].Value;
                        }
                    }
                    package.Save();
                }
            }
        }

        private void dataGrid_cloth_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

    }
}
