using ClothDAL;
using ClothModel;
using ClothUI.stuffManager._1;
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
    public partial class Stuff : Form
    {
        private string _id;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stuff));
        public Stuff()
        {
            InitializeComponent();
            pal_personList.Hide();
            InnerFormHelper.InitInnerPanelListView(list_person, pal_personList, "身份证","姓名","职位","在职状态");
            pal_personList.Hide();
        }

        public void SetId(string id)
        {
            this._id = id;
        }

        private void InitLabInfo()
        {
            lbl_R_address.Text = "";
            lbl_R_bankName.Text = "";
            lbl_R_bankNumber.Text = "";
            lbl_R_birthday.Text = "";
            lbl_R_department.Text = "";
            lbl_R_edubackgroud.Text = "";
            lbl_R_entrytime.Text = "";
            lbl_R_hometown.Text = "";
            lbl_R_ID.Text = "";
            lbl_R_mail.Text = "";
            lbl_R_major.Text = "";
            lbl_R_name.Text = "";
            lbl_R_nation.Text = "";
            lbl_R_office.Text = "";
            lbl_R_salary.Text = "";
            lbl_R_school.Text = "";
            lbl_R_sex.Text = "";
            lbl_R_specialty.Text = "";
            lbl_R_telNumber.Text = "";
            lbl_R_state.Text = "";
        }

        private void BindLabInfoWithPerson(Person person)
        {
            if(person == null)
                return ;

            lbl_R_address.Text = person.Address;
            lbl_R_bankName.Text = person.BankName;
            lbl_R_bankNumber.Text = person.BankNumber;
            lbl_R_birthday.Text = person.Birthday.ToString("yyyy-MM-dd");
            lbl_R_department.Text = person.Department;
            lbl_R_edubackgroud.Text = person.EduBackGround;
            lbl_R_entrytime.Text = person.Entrytime.ToString("yyyy-MM-dd");
            lbl_R_hometown.Text = person.HomeTown;
            lbl_R_ID.Text = person.ID;
            lbl_R_mail.Text = person.MailNumber;
            lbl_R_major.Text = person.Major;
            lbl_R_name.Text = person.Name;
            lbl_R_nation.Text = person.Nation;
            lbl_R_office.Text = person.Office;
            lbl_R_salary.Text = person.Salary.ToString();
            lbl_R_school.Text = person.School;
            lbl_R_sex.Text = person.Sex;
            lbl_R_specialty.Text = person.Specialty;
            lbl_R_telNumber.Text = person.TelNumber;
            lbl_R_state.Text = person.State;
        }

        private void ShowImg(byte[] imgBytes)
        {
            if(imgBytes != null)
            {
                try
                {
                    MemoryStream stream = new MemoryStream(imgBytes);
                    pic_person.Image = Image.FromStream(stream);
                }
                catch(Exception ex)
                {
                    pic_person.Image = ((System.Drawing.Image)(resources.GetObject("pic_person.Image")));
                }
                
            }
        }

        private void BindPerson(Person person)
        {
            BindLabInfoWithPerson(person);
            ShowImg(person.Photo);
        }

        private void Stuff_Load(object sender, EventArgs e)
        {
            InitLabInfo();
            btn_print.Hide();
            btn_askforleave.PerformClick();
            
        }

        private void DrawListView(params String [] colNames)
        {
            foreach (String name in colNames)
            {
                list_data.Columns.Add(name);
            }
        }
        
        private void btn_askforleave_Click(object sender, EventArgs e)
        {
            pal_bottom_middle.Show();
            list_data.Clear();
            list_data.CheckBoxes = true;
            DrawListView("", "身份证", "姓名", "请假时间", "天数", "原因");
            AskForLeaveDAL afld = new AskForLeaveDAL();
            AskForLeave [] afls = afld.Search(lbl_R_ID.Text);
            if(afls != null)
            {
                foreach(AskForLeave afl in afls)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(afl.ID);
                    item.SubItems.Add(afl.Name);
                    item.SubItems.Add(afl.Time.ToString("yyyy/MM/dd"));
                    item.SubItems.Add(afl.Days.ToString());
                    item.SubItems.Add(afl.Reason);
                    list_data.Items.Add(item);
                }
            }
        }

        private void btn_salaryChange_Click(object sender, EventArgs e)
        {
            pal_bottom_middle.Hide();
            list_data.Clear();
            list_data.CheckBoxes = false;
            DrawListView("身份证", "姓名", "旧薪资", "现薪资", "详情","调薪时间");
            AlterSalaryDAL asd = new AlterSalaryDAL();
            MAlterSalary [] mas = asd.Search(lbl_R_ID.Text);
            if (mas != null)
            {
                foreach(MAlterSalary ma in mas)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ma.ID;
                    item.SubItems.Add(ma.PersonName);
                    item.SubItems.Add(ma.OldSalary.ToString());
                    item.SubItems.Add(ma.NewSalary.ToString());
                    item.SubItems.Add(ma.Reason);
                    item.SubItems.Add(ma.Time.ToString("yyyy/MM/dd"));
                    list_data.Items.Add(item);
                }
            }
        }

        private void btn_saleInfo_Click(object sender, EventArgs e)
        {
            pal_bottom_middle.Hide();
            list_data.Clear();
            list_data.CheckBoxes = false;
            DrawListView("条纹码", "品牌", "款式", "颜色", "尺寸","销售价", "销售时间");
            SaleSheetDAL sd = new SaleSheetDAL();
            Cloth [] clothes = sd.ListTheCloth(lbl_R_ID.Text);
            if(clothes != null)
            {
                foreach(Cloth cloth in clothes)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = cloth.ID;
                    item.SubItems.Add(cloth.Name);
                    item.SubItems.Add(cloth.Style);
                    item.SubItems.Add(cloth.Color);
                    item.SubItems.Add(cloth.Size);
                    item.SubItems.Add(cloth.SalePrice.ToString());
                    item.SubItems.Add(sd.GetTheSoldDateTime(cloth.ID).ToString("yyyy/MM/dd"));
                    list_data.Items.Add(item);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(lbl_R_ID.Text != "")
            {
                PersonDAL pd = new PersonDAL();
                Leave leave = new stuffManager._1.Leave();
                leave.Flag = "Leave";
                if (leave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AskForLeaveDAL afld = new AskForLeaveDAL();
                    AskForLeave afl = new AskForLeave();
                    afl.ID = lbl_R_ID.Text;
                    afl.Name = lbl_R_name.Text;
                    afl.Time = Convert.ToDateTime(leave.Time);
                    afl.Reason = leave.Reason;
                    afl.Days = int.Parse(leave.Days);
                    if (afld.Insert(afl) != 1)
                    {
                        MessageBox.Show("联网异常");
                        return;
                    }
                    pd.AlterState(lbl_R_ID.Text, "休假");
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(afl.ID);
                    item.SubItems.Add(afl.Name);
                    item.SubItems.Add(afl.Time.ToString("yyyy/MM/dd"));
                    item.SubItems.Add(afl.Days.ToString());
                    item.SubItems.Add(afl.Reason);
                    list_data.Items.Add(item);
                    
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in list_data.CheckedItems)
            {
                AskForLeaveDAL ad = new AskForLeaveDAL();
                if(ad.Delete(item.SubItems[1].Text,Convert.ToDateTime(item.SubItems[3].Text)) != 1)
                {
                    MessageBox.Show("检查联网");
                }
                item.Remove();
            }
            //list_data.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (list_person.Items.Count != 0)
                list_person.Items.Clear();
            PersonDAL personDal = new PersonDAL();
            Person[] persons;
            if(txt_search.Text == "")
            {
                //list all
                persons = personDal.ListAll();
            }
            else
            {
                persons = personDal.SearchByName(txt_search.Text);
            }

            foreach(Person person in persons)
            {
                ListViewItem item = new ListViewItem();
                item.Text = person.ID;
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.Office);
                item.SubItems.Add(person.State);
                list_person.Items.Add(item);
            }
            
            pal_personList.Show();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            pal_personList.Hide();
        }

        private void btn_uploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "图片|*.jpg;*.jpeg|png图片|*.png";
            if (lbl_R_ID.Text != "")
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String fileName = fileDialog.FileName;
                    pic_person.Image = Image.FromFile(fileName);

                    byte[] photo = File.ReadAllBytes(fileName);
                    PersonDAL pd = new PersonDAL();
                    pd.UpdateImage(photo, lbl_R_ID.Text);

                }
            }
            
        }

        private void btn_personMgr_Click(object sender, EventArgs e)
        {
            personMgr pm = new personMgr();
            pm.ShowDialog();
        }

        private void list_person_DoubleClick(object sender, EventArgs e)
        {
            pic_person.Image = ((System.Drawing.Image)(resources.GetObject("pic_person.Image")));
            ListViewItem item = list_person.SelectedItems[0];
            PersonDAL personDal = new PersonDAL();
            Person person = personDal.SearchById(item.Text);
            pal_personList.Hide();
            BindPerson(person);
            btn_askforleave.PerformClick();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            list_person_DoubleClick(sender, e);
        }

        private void btn_addPerson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.OpenState = OPENSTATE.Insert;
            addPerson.Text = "新增员工";
            addPerson.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_R_ID.Text != "")
            {
                AddPerson addPerson = new AddPerson();
                addPerson.OpenState = OPENSTATE.Edit;
                addPerson.Text = "编辑员工";
                addPerson.SetId(lbl_R_ID.Text);
                addPerson.ShowDialog();
            }
            
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (lbl_R_ID.Text != "")
            {
                AddPerson addPerson = new AddPerson();
                addPerson.OpenState = OPENSTATE.ReadOnly;
                addPerson.Text = "查看员工";
                addPerson.SetId(lbl_R_ID.Text);
                addPerson.ShowDialog();
            }
        }

    }
}
