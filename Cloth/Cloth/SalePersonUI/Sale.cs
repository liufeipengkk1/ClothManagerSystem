using ClothDAL;
using ClothModel;
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

/*
 *  问题残留： datagrid_cloth:是否要去重操作？
 *  
 *  事实上当人们扫描条纹码的时候，是不可能出现重复数据的，但可能扫不出的时候手动添加可能会出现误操作。
 * 
 */

namespace SalePersonUI
{
    public partial class Sale : Form
    {
        private string _ID;
        private Person _person;
        private PersonDAL personDal = new PersonDAL();
        private int currentIndex = -1;
        private string salePersonId;
        //private bool flag = false;

        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            //load the username,and get the saleperson information
            _person = personDal.SearchById(_ID);
            lbl_name.Text = _person.Name;
            
            //load the photo
            if(_person.Photo != null)
            {
                MemoryStream stream = new MemoryStream(_person.Photo);
                picture_header.Image = Image.FromStream(stream); 
            }
            
            lbl_showMoney.Text = "0";
            lbl_jiesuan.Text = "未结算";

            list_name.Columns.Add("ID",70);
            list_name.Columns.Add("姓名",70);
            list_name.Columns.Add("职务");
            pal_list.Hide();

        }

        public void SetID(string id)
        {
            _ID = id;
        }

        //结账：写入数据库，更改表CLOTH SALE_SHEET
        private bool WriteBill()
        {
            CClothDAL clothDal = new CClothDAL();
            SaleSheetDAL salesheet = new SaleSheetDAL();
            TiChengDAL tcd = new TiChengDAL();
            MTiCheng[] tcs = tcd.ListAll();
            float ticheng = 0;
            int count = dataGrid_cloth.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                DataGridViewRow row = dataGrid_cloth.Rows[i];
                string clothid = Convert.ToString(row.Cells[0].Value);

                if (salePersonId == null)
                {
                    MessageBox.Show("销售人员为空");
                    return false;
                }
                if(tcs != null)
                {
                    foreach(MTiCheng tc in tcs)
                    {
                        int price = Convert.ToInt32(row.Cells[5].Value);
                        if(tc.Down < price && tc.Up >= price)
                        { 
                            if(tc.Ways == WAY.MONEY)
                            {
                                ticheng = tc.Money;
                            }
                            else
                            {
                                ticheng = ticheng * (1 + tc.Money);
                            }
                        }
                    }
                }
                salesheet.Insert(salePersonId, clothid,ticheng);
                clothDal.AlterSaleState(clothid, SALESTATE.sold);
                //写入销售价
                clothDal.AlterSalePrice(clothid,Convert.ToSingle(row.Cells[5].Value));
                
            }
            return true;
        }

        //退款操作
        private void Refund()
        {
            CClothDAL clothDal = new CClothDAL();
            SaleSheetDAL salesheet = new SaleSheetDAL();
            int count = dataGrid_cloth.Rows.Count;
            for (int i = 0; i < count - 1; i++)
            {
                DataGridViewRow row = dataGrid_cloth.Rows[i];
                string clothid = Convert.ToString(row.Cells[0].Value);
                clothDal.AlterSaleState(clothid, SALESTATE.onsale);
                salesheet.Delete(clothid);
                //salesheet.Delete(salePersonId, clothid);
                //写入销售价
                clothDal.AlterSalePrice(clothid, 0);
            }
        }

        //扫描进商品清单
        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_id.Text !="")
            {
                CClothDAL clothDAL = new CClothDAL();
                Cloth cloth = clothDAL.SearchById(txt_id.Text);
                if (cloth == null)
                    return;

                DataGridViewRow dr = new DataGridViewRow();
                ActivityDAL ad = new ActivityDAL();
                dr.CreateCells(dataGrid_cloth);
                dr.Cells[0].Value = txt_id.Text;
                dr.Cells[1].Value = cloth.Name;
                dr.Cells[2].Value = cloth.Style;
                dr.Cells[3].Value = cloth.Color;
                dr.Cells[4].Value = cloth.Size;
                float saleprice = ad.GetTheSalePrice(txt_id.Text);
                if(saleprice == 0)
                {
                    dr.Cells[5].Value = cloth.Price;                //写入售价的时候：应浏览是否在活动范围内
                    saleprice = cloth.Price;
                }
                else
                {
                    dr.Cells[5].Value = saleprice;
                }
                dataGrid_cloth.Rows.Add(dr);
                lbl_showMoney.Text = (float.Parse(lbl_showMoney.Text) + saleprice).ToString();
                txt_id.Text = "";
            }

        }

        //扫描要删除的商品
        private void txt_iddelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_iddelete.Text != "")
            {
                lbl_jiesuan.Text = "未结算";
                foreach (DataGridViewRow row in dataGrid_cloth.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == txt_iddelete.Text)
                    {
                        string price = Convert.ToString(row.Cells[5].Value);
                        lbl_showMoney.Text = (float.Parse(lbl_showMoney.Text) - float.Parse(price)).ToString();
                        dataGrid_cloth.Rows.Remove(row);
                    }
                }
                txt_iddelete.Text = "";
            }
        }

        private void Sale_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers ==  Keys.Control && e.KeyCode == Keys.Enter)
            {
                //datagrid 只有一行时候，表示没有数据
                if (dataGrid_cloth.Rows.Count == 1)
                    return;

                lbl_jiesuan.Text = "结算中...";
                Bill b = new Bill();
                b.Text = "结账";
                b.Money = lbl_showMoney.Text;
                if(b.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //结算
                    if(!WriteBill())
                    {
                        return;
                    }
                    dataGrid_cloth.Rows.Clear();
                    lbl_jiesuan.Text = "结算完成";
                    lbl_showMoney.Text = "0";
                }
            }
            else if(e.KeyCode == Keys.F5)   //F5清空列表
            {
                dataGrid_cloth.Rows.Clear();
                lbl_jiesuan.Text = "未结算";
                lbl_showMoney.Text = "0";
            }
            else if (e.KeyCode == Keys.F8)
            {
                Alterpaswd ap = new Alterpaswd();
                ap.ID = _ID;
                ap.ShowDialog();
            }
            else if(e.KeyCode == Keys.F1) // F1退款程式
            {
                //datagrid 只有一行时候，表示没有数据
                if (dataGrid_cloth.Rows.Count == 1)
                    return;
                Bill b = new Bill();
                b.Money = lbl_showMoney.Text;
                b.Text = "退款";
                if (b.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //结算
                    Refund();
                    dataGrid_cloth.Rows.Clear();
                    lbl_jiesuan.Text = "结算完成";
                    lbl_showMoney.Text = "0";
                }
            }
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if(currentIndex != -1 && currentIndex < dataGrid_cloth.Rows.Count)
            {
                float price = float.Parse(Convert.ToString(dataGrid_cloth.Rows[currentIndex].Cells[5].Value));
                lbl_showMoney.Text = (float.Parse(lbl_showMoney.Text) - price).ToString();
                dataGrid_cloth.Rows.RemoveAt(currentIndex);
            }
        }

        private void dataGrid_cloth_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //get the current focused row
            currentIndex = e.RowIndex;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            pal_list.Show();
            list_name.Items.Clear();
            Person[] persons;
            if(txt_saleperson.Text == "")
            {
                persons = personDal.ListAll();
            }
            else 
            {
                persons = personDal.SearchByName(txt_saleperson.Text);
            }

            foreach(Person person in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = person.ID;
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.Office);
                list_name.Items.Add(item);
            }
            
        }

        private void list_name_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = list_name.SelectedItems[0];
            txt_saleperson.Text = item.SubItems[1].Text;
            salePersonId = item.Text;
            pal_list.Hide();
        }
    }
}
