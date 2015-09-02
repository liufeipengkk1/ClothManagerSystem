using ClothDAL;
using ClothModel;
using ClothUI.stuffManager._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothUI
{
    public partial class AddPerson : Form
    {
        private int CalendarWidth = 220;
        private int CalendarHeight = 208;
        //private int pal_bankNumberWidth = 321;
        //private int pal_bankNumberHeight = 33;
        private byte[] photo;
        public String OpenState { get; set; }
        public String Id { get; set; }
        private Person addPerson = new Person();
        private Person editPerson;
        private string entryTime;
        private string bithday;

        private cVideo cv;
        
        public AddPerson()
        {
            InitializeComponent();
        }

        public AddPerson(String id)
        {
            InitializeComponent();
            Id = id;
        }

        public void SetId(string id)
        {
            Id = id;
        }

        //初始化
        private void AddPerson_Load(object sender, EventArgs e)
        {
            btn_birthday.FlatAppearance.BorderSize = 0;
            btn_entryTime.FlatAppearance.BorderSize = 0;
            txt_birday.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txt_entryTime.Text = DateTime.Now.ToString("yyyy/MM/dd");
            pal_dayChoose.Size = new System.Drawing.Size(CalendarWidth,CalendarHeight);
            pal_bankNumber.Size = new System.Drawing.Size(321, 33);
            pal_bankNumber.Hide();
            pal_dayChoose.Hide();

            if(OpenState == "")
            {
                MessageBox.Show("异常");
            }
            else if(OpenState == OPENSTATE.ReadOnly || OpenState == OPENSTATE.Edit)
            {
                PersonDAL personDal = new PersonDAL();
                editPerson = personDal.SearchById(Id);
                if(editPerson == null)
                {
                    this.Close();
                }
                BindPerson(editPerson);
                txt_id.Enabled = false;
            }

            cbx_office.Items.Add("销售员");
            cbx_office.Items.Add("进货员");
            cbx_office.Items.Add("店长");
            cbx_office.Items.Add("管理员");

            pal_tkPhoto.Hide();
            cv = new cVideo(pic_photo.Handle, pic_photo.Width, pic_photo.Height);
        }

        private void ShowImage(byte [] img)
        {
            if(img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pic_header.Image = Image.FromStream(ms);
            }
        }

        private void BindPerson(Person person)
        {
            txt_Name.Text = person.Name;
            txt_sex.Text  = person.Sex;
            txt_birday.Text = person.Birthday.ToString("yyyy/MM/dd");
            txt_entryTime.Text = person.Entrytime.ToString("yyyy/MM/dd");
            txt_nation.Text = person.Nation;
            txt_hometown.Text = person.HomeTown;
            txt_edu.Text = person.EduBackGround;
            txt_specialty.Text = person.Major;
            txt_id.Text = person.ID ;
            txt_email.Text = person.MailNumber;
            txt_school.Text = person.School;
            txt_address.Text = person.Address;
            txt_telnumber.Text = person.TelNumber;
            txt_salary.Text = person.Salary.ToString();
            txt_bankNumber.Text = person.BankNumber;
            txt_bankName.Text = person.BankName;
            cbx_department.Text = person.Department;
            cbx_office.Text = person.Office;
            txt_zhicheng.Text = person.Specialty ;
            txt_resume.Text = person.Resume;
            txt_mark.Text = person.Remark;

            ShowImage(person.Photo);

        }

        private void WritePerson(Person person)
        {
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd";

            person.Name = txt_Name.Text;
            person.Sex = txt_sex.Text;
            person.Birthday = Convert.ToDateTime(txt_birday.Text,dtFormat);
            person.Entrytime = Convert.ToDateTime(txt_entryTime.Text,dtFormat);
            person.Nation = txt_nation.Text;
            person.HomeTown = txt_hometown.Text;
            person.EduBackGround = txt_edu.Text;
            person.Major = txt_specialty.Text;
            person.ID = txt_id.Text;
            person.MailNumber = txt_email.Text;
            person.School = txt_school.Text;
            person.Address = txt_address.Text;
            person.TelNumber = txt_telnumber.Text;
            person.Salary = long.Parse(txt_salary.Text);
            person.BankNumber = txt_bankNumber.Text;
            person.BankName = txt_bankName.Text;
            person.Department = cbx_department.Text;
            person.Office = cbx_office.Text;
            person.Specialty = txt_zhicheng.Text;
            person.Resume = txt_resume.Text;
            person.Remark = txt_mark.Text;
            person.Photo = photo;

            //default password 123456
            //default values
            if(person.Passwd == null)
                person.Passwd = "123456";
            if(person.FinalSalary == 0)
                person.FinalSalary = person.Salary;
            if(person.Office == "销售员")
                person.Limit = PERSONLIMIT.saleperson;
            else if(person.Office == "进货员")
                person.Limit = PERSONLIMIT.registrar;
            else if (person.Office == "管理员")
                person.Limit = PERSONLIMIT.admin;
            else if (person.Office == "店长")
                person.Limit = PERSONLIMIT.agent;
            person.State = "在职";
        }

        private void SavePerson(Person person)
        {
            PersonDAL pd = new PersonDAL();
            int flag = pd.InsertPerson(person);
            if (flag == -1)
            {
                MessageBox.Show("该身份证ID已经存在！！！！");
            }
            else if (flag == 0)
            {
                MessageBox.Show("请检查联网状态！！！！");
            }
        }

        private void UpdatePerson(Person person)
        {
            PersonDAL pd = new PersonDAL();
            if(pd.Update(person) != 1)
            {
                MessageBox.Show("检查联网状态");
            }
        }

        //出生日期按钮
        private void btn_birthday_Click(object sender, EventArgs e)
        {
            pal_dayChoose.Location = new Point(123, 144);
            pal_dayChoose.Show();
        }

        //点击今天按钮
        private void btn_today_Click(object sender, EventArgs e)
        {
            if (pal_dayChoose.Location.X > 123)
            {
                txt_entryTime.Text = monthCal_choose.SelectionEnd.ToString("yyyy/MM/dd");
            }
            else
            {
                txt_birday.Text = monthCal_choose.SelectionEnd.ToString("yyyy/MM/dd");
            }
            pal_dayChoose.Hide();
        }
        //取消按钮
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pal_dayChoose.Hide();
        }
        //时间选择触发事件
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if(pal_dayChoose.Location.X > 123)
            {
               txt_entryTime.Text = monthCal_choose.SelectionEnd.ToString("yyyy/MM/dd");
            }
            else
            {
                txt_birday.Text = monthCal_choose.SelectionEnd.ToString("yyyy/MM/dd");
            }
           
            pal_dayChoose.Hide();
        }
        //入职日期选择
        private void btn_entryTime_Click(object sender, EventArgs e)
        {
            pal_dayChoose.Location = new Point(343, 144);
            pal_dayChoose.Show();
        }
        

        private void txt_bankNumber_MouseLeave(object sender, EventArgs e)
        {
            pal_bankNumber.Hide();
           
        }

        private void txt_bankNumber_TextChanged(object sender, EventArgs e)
        {
            pal_bankNumber.Show();
            txt_bankNumberTop.Text = txt_bankNumber.Text;
        }

        private void txt_bankNumber_MouseHover(object sender, EventArgs e)
        {
            pal_bankNumber.Show();
            txt_bankNumberTop.Text = txt_bankNumber.Text;
        }

        private void txt_bankNumber_MouseEnter(object sender, EventArgs e)
        {
            pal_bankNumber.Show();
            txt_bankNumberTop.Text = txt_bankNumber.Text;
        }

        private void menu_upLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "图片|*.jpg;*.jpeg|png图片|*.png";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String fileName = fileDialog.FileName;

                //添加照片
                photo = File.ReadAllBytes(fileName);  //--->转化为byte
                pic_header.Image = Image.FromFile(fileName);
                
            }
        }

        
        private void btn_personOK_Click(object sender, EventArgs e)
        {
            PersonDAL pd = new PersonDAL();
            if(OpenState == OPENSTATE.Insert)
            {
                WritePerson(addPerson);
                SavePerson(addPerson);
            }
            else if(OpenState == OPENSTATE.ReadOnly)
            {
                this.Close();
            }
            else if(OpenState == OPENSTATE.Edit)
            {
                WritePerson(editPerson);
                UpdatePerson(editPerson);
            }

            this.Close();
        }

        private void btn_personCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deletePhoto_Click(object sender, EventArgs e)
        {
            pic_header.Image = null;
            photo = null;
        }

        private void btn_setPhoto_MouseClick(object sender, MouseEventArgs e)
        {
            
            contextMenuStrip_picHead.Show((Button)sender,new Point(e.X,e.Y));
        }

        private void menu_takePic_Click(object sender, EventArgs e)
        {
            pal_tkPhoto.Show();
            cv.StartWebCam();
        }

        private void AddPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cv.CloseWebcam();   
            }
        }

        private void btn_takephoto_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            try
            {
                cv.GrabImage(pic_photo.Handle, "BUFFER.DAT");
                pic_header.Image = Image.FromFile("BUFFER.DAT");
                photo = File.ReadAllBytes("BUFFER.DAT");
                 
                ShowImage(photo);
                ms.Close();
                cv.CloseWebcam();
            }
            catch(Exception)
            {
                ms.Close();
                cv.CloseWebcam();
            }
            pal_tkPhoto.Hide();
        }

        private void btn_photoCancel_Click(object sender, EventArgs e)
        {
            cv.CloseWebcam();
            pal_tkPhoto.Hide();
        }
    }
}
;