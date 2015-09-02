using ClothDAL;
using ClothModel;
using ClothUI.stuffManager._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace ClothUI
{
    public partial class personMgr : Form
    {
        public personMgr()
        {
            InitializeComponent();
        }

        private void btn_state_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip_state.Show((Button)sender, new Point(e.X, e.Y));
        }

        private void btn_signOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitList()
        {
            list_data.Columns.Add("身份证", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("姓名", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("性别", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("民族", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("生日", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("入职时间", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("在职状态", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("基本工资", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("电话", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("邮箱", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("银行卡号", 100, HorizontalAlignment.Left);
            list_data.Columns.Add("所属银行", 100, HorizontalAlignment.Left);
        }

        private void BindPersons(Person [] persons)
        {
            foreach (Person person in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = person.ID;
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.Sex);
                item.SubItems.Add(person.Nation);
                if (person.Birthday != null)
                {
                    item.SubItems.Add(person.Birthday.ToString("yyyy/MM/dd"));
                }
                else
                {
                    item.SubItems.Add("");
                }

                if (person.Entrytime != null)
                    item.SubItems.Add(person.Entrytime.ToString("yyyy/MM/dd"));
                else
                    item.SubItems.Add("");
                item.SubItems.Add(person.State);
                item.SubItems.Add(person.Salary.ToString());
                item.SubItems.Add(person.TelNumber);
                item.SubItems.Add(person.MailNumber);
                item.SubItems.Add(person.BankNumber);
                item.SubItems.Add(person.BankName);
                list_data.Items.Add(item);
            }
        }

        private void personMgr_Load(object sender, EventArgs e)
        {
            InitList();
            btn_search.Hide();
            btn_print.Hide();
            btn_import.Hide();
            PersonDAL pd = new PersonDAL();
            Person [] persons = pd.ListAll();
            BindPersons(persons);
        }

        //search
        private void button1_Click(object sender, EventArgs e)
        {
            list_data.Items.Clear();
            PersonDAL pd = new PersonDAL();
            if (txt_search.Text != "")
            {
                Person[] persons = pd.SearchByName(txt_search.Text);
                BindPersons(persons);
            }
            else
            {
                Person[] persons = pd.ListAll();
                BindPersons(persons);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.OpenState = OPENSTATE.Insert;
            addPerson.Text = "新增员工";
            addPerson.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(list_data.SelectedItems.Count != 0)
            {
                ListViewItem item = list_data.SelectedItems[0];
                AddPerson addPerson = new AddPerson();
                addPerson.OpenState = OPENSTATE.Edit;
                addPerson.Text = "编辑员工";
                addPerson.SetId(item.Text);
                addPerson.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (list_data.SelectedItems.Count != 0)
            {
                ListViewItem item = list_data.SelectedItems[0];
                PersonDAL pd = new PersonDAL();
                AlterSalaryDAL ad = new AlterSalaryDAL();
                AskForLeaveDAL asd = new AskForLeaveDAL();
                ad.Delete(item.Text);
                asd.Delete(item.Text);
                if(pd.DeletePerson(item.Text) != 1)
                {
                    MessageBox.Show("检查联网状态");
                    return;
                }
                
                list_data.Items.Remove(item);
                list_data.Refresh();
            }
        }

        //离职清单 休假清单这块是不是要更改？
        private void contextMenuStrip_state_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (list_data.SelectedItems.Count != 0)
            {
                ListViewItem item = list_data.SelectedItems[0];
                Leave leave = new stuffManager._1.Leave();
                string flag = e.ClickedItem.Text;
                if (flag == "休假")
                {
                    leave.Flag = "Leave";
                }
                else if(flag == "离职")
                {
                    leave.Flag = "Resignation";
                }

                if(flag != "在职")
                {
                    if (leave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (flag == "休假")
                        {
                            AskForLeaveDAL afld = new AskForLeaveDAL();
                            AskForLeave afl = new AskForLeave();
                            afl.ID = item.Text;
                            afl.Name = item.SubItems[1].Text;
                            afl.Time = Convert.ToDateTime(leave.Time);
                            afl.Reason = leave.Reason;
                            afl.Days = int.Parse(leave.Days);
                            if (afld.Insert(afl) != 1)
                            {
                                MessageBox.Show("联网异常");
                                return;
                            }
                        }
                        else if (flag == "离职")
                        {
                            Resignation rg = new Resignation();
                            ResignationDAL rgDal = new ResignationDAL();
                            rg.ID = item.Text;
                            rg.Name = item.SubItems[1].Text;
                            rg.Time = Convert.ToDateTime(leave.Time);
                            rg.Reason = leave.Reason;
                            if (rgDal.Insert(rg) != 1)
                            {
                                MessageBox.Show("联网异常");
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                

                PersonDAL pd = new PersonDAL();
                if (pd.AlterState(item.Text, e.ClickedItem.Text) != 1)
                {
                    MessageBox.Show("检查联网状态");
                    return;
                }
                item.SubItems[6].Text = e.ClickedItem.Text;
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
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
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("人员清单");
                    //add header
                    int colCount = list_data.Columns.Count;
                    int rowCount = list_data.Items.Count;
                    for (int i = 0; i < colCount; i++)
                        worksheet.Cells[1, i + 1].Value = list_data.Columns[i].Text;
                    //add the items
                    int row = 0;
                    int col = 0;
                    for (row = 0; row < rowCount; row++)
                    {
                        for (col = 0; col < colCount; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = list_data.Items[row].SubItems[col].Text;
                        }
                    }
                    //  worksheet.Cells["A1:K11"].Style.Font.Color.SetColor(Color.Red);
                    package.Save();
                }
            }
        }
    }
}
