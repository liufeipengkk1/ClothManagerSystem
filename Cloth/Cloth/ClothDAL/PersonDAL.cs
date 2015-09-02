using ClothModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothDAL
{
    /// <summary>
    /// 人员管理:增加/删除 查看
    /// </summary>
    public class PersonDAL
    {
        //查询出来的一行转化成model
        public Person ToModel(DataRow row)
        { 
            if(row == null)
            {
                return null;
            }

            Person person = new Person();

            person.ID = (String)row["id"];
            person.Name = (String)row["name"];
            person.Passwd = (String)row["passwd"];
            person.Salary = Convert.ToSingle(row["salary"]);
            person.FinalSalary = Convert.ToSingle(row["finnalsalary"]);

            //person.Salary = (float)row["salary"];
            //person.FinalSalary = (float)row["finnalsalary"];
            person.Limit = (String)row["limites"];
            person.BankNumber = (String)SqlHelper.FromDbValue(row["banknumber"]);
            person.TelNumber = (String)SqlHelper.FromDbValue(row["telnumber"]);
            person.MailNumber = (String)SqlHelper.FromDbValue(row["mailnumber"]);
            person.Photo = (byte[])SqlHelper.FromDbValue(row["photo"]);


            person.Birthday = Convert.ToDateTime( SqlHelper.FromDbValue(row["birthday"]));
            person.Nation = (String)SqlHelper.FromDbValue(row["nation"]);
            person.Sex = (String)SqlHelper.FromDbValue(row["Sex"]);
            person.Address = (String)SqlHelper.FromDbValue(row["Address"]);
            person.Department = (String)SqlHelper.FromDbValue(row["Department"]);
            person.Office = (String)SqlHelper.FromDbValue(row["Office"]);
            person.Specialty = (String)SqlHelper.FromDbValue(row["Specialty"]);
            person.School = (String)SqlHelper.FromDbValue(row["School"]);
            person.Entrytime = Convert.ToDateTime(SqlHelper.FromDbValue(row["Entrytime"]));
            person.State = (String)SqlHelper.FromDbValue(row["State"]);
            person.EduBackGround = (String)SqlHelper.FromDbValue(row["EduBackGround"]);
            person.Resume = (String)SqlHelper.FromDbValue(row["Resume"]);
            person.Remark = (String)SqlHelper.FromDbValue(row["Remark"]);
            person.HomeTown = (String)SqlHelper.FromDbValue(row["HomeTown"]);
            person.Major = (String)SqlHelper.FromDbValue(row["Major"]);
            person.BankName = (String)SqlHelper.FromDbValue(row["BankName"]);

            return person;
        }

        public bool LoginVerufication(String id,String passwd,String limit)
        {
            int result = (int)SqlHelper.ExecuteScalar("select count(id) from person where id = @id and passwd=@passwd and limites=@limit"
                ,new SqlParameter("@id",id)
                , new SqlParameter("@passwd",passwd)
                , new SqlParameter("@limit", limit));

            if(result == 1)
            {
                return true;
            }
            else if(result == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }


        //增加一个员工
        public int InsertPerson(Person person)
        {
            //插入的时候检查一下这个人是否存在此ID号码
            Person p = SearchById(person.ID);
            if(p != null)
            {
                return -1;
            }
            SqlParameter photoPara = new SqlParameter("@PHOTO", SqlHelper.ToDbValue(person.Photo));
            photoPara.SqlDbType = SqlDbType.Image;
            return SqlHelper.ExecuteNonQuery(@"INSERT INTO PERSON
            (ID,NAME,PASSWD,BANKNUMBER,TELNUMBER,MAILNUMBER,SALARY,
            FINNALSALARY,PHOTO,LIMITES,Birthday,Nation,Sex,Address,
            Department,Office,Specialty,School,Entrytime,State,EduBackGround,
            Resume,Remark,HomeTown,Major,BankName) VALUES(@ID,@NAME,@PASSWD,@BANKNUMBER,
            @TELNUMBER,@MAILNUMBER,@SALARY,@FINNALSALARY,@PHOTO,@LIMITES,
            @Birthday,@Nation,@Sex,@Address,@Department,@Office,@Specialty,@School,
            @Entrytime,@State,@EduBackGround,@Resume,@Remark,@HomeTown,@Major,@BankName)", new SqlParameter("@ID", person.ID)
                                                                         , new SqlParameter("@NAME", person.Name)
                                                                         , new SqlParameter("@PASSWD", person.Passwd)
                                                                         , new SqlParameter("@BANKNUMBER", person.BankNumber)
                                                                         , new SqlParameter("@TELNUMBER", SqlHelper.ToDbValue(person.TelNumber))
                                                                         , new SqlParameter("@MAILNUMBER", SqlHelper.ToDbValue(person.MailNumber))
                                                                         , new SqlParameter("@SALARY", person.Salary)
                                                                         , new SqlParameter("@FINNALSALARY", person.FinalSalary)
                                                                         , photoPara
                                                                         , new SqlParameter("@LIMITES", person.Limit)
                                                                         , new SqlParameter("@Birthday", SqlHelper.ToDbValue(person.Birthday))
                                                                         , new SqlParameter("@Nation", SqlHelper.ToDbValue(person.Nation))
                                                                         , new SqlParameter("@Sex", SqlHelper.ToDbValue(person.Sex))
                                                                         , new SqlParameter("@Address", SqlHelper.ToDbValue(person.Address))
                                                                         , new SqlParameter("@Department", SqlHelper.ToDbValue(person.Department))
                                                                         , new SqlParameter("@Office",SqlHelper.ToDbValue(person.Office))
                                                                         , new SqlParameter("@Specialty", SqlHelper.ToDbValue(person.Specialty))
                                                                         , new SqlParameter("@School", SqlHelper.ToDbValue(person.School))
                                                                         , new SqlParameter("@Entrytime", SqlHelper.ToDbValue(person.Entrytime))
                                                                         , new SqlParameter("@State", SqlHelper.ToDbValue(person.State))
                                                                         , new SqlParameter("@EduBackGround", SqlHelper.ToDbValue(person.EduBackGround))
                                                                         , new SqlParameter("@Resume", SqlHelper.ToDbValue(person.Resume))
                                                                         , new SqlParameter("@Remark", SqlHelper.ToDbValue(person.Remark))
                                                                         , new SqlParameter("@HomeTown", SqlHelper.ToDbValue(person.HomeTown))
                                                                         , new SqlParameter("@Major",SqlHelper.ToDbValue(person.Major))
                                                                         , new SqlParameter("@BankName", SqlHelper.ToDbValue(person.BankName)));
        }
        //删除一个员工 需要删除一个人的所有信息 包括请假 辞职信 销售清单等等
        public int DeletePerson(Person person)
        {
            //SqlHelper.ExecuteNonQuery(@"DELETE FROM BeLate WHERE ID=@ID", new SqlParameter("@ID", person.ID));
            //SqlHelper.ExecuteNonQuery(@"DELETE FROM AskForLeave WHERE ID=@ID", new SqlParameter("@ID", person.ID));
            //SqlHelper.ExecuteNonQuery(@"DELETE FROM Resignation WHERE ID=@ID", new SqlParameter("@ID", person.ID));
            //SqlHelper.ExecuteNonQuery(@"DELETE FROM Sale_Sheet WHERE ID=@ID", new SqlParameter("@ID", person.ID));
            return SqlHelper.ExecuteNonQuery(@"DELETE FROM PERSON WHERE ID=@ID",new SqlParameter("@ID",person.ID));
        }

        public int AlterState(String id,String state)
        {
            return SqlHelper.ExecuteNonQuery("Update person set state=@state where id=@id",new SqlParameter("@state",state)
                ,new SqlParameter("@id",id));
        }

        public int DeletePerson(string id)
        {
            return SqlHelper.ExecuteNonQuery(@"DELETE FROM PERSON WHERE ID=@ID", new SqlParameter("@ID", id));
        }

        //通过ID查询
        public Person SearchById(String id) 
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON WHERE ID=@ID",
                new SqlParameter("@ID",id));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if(count == 0)
            {
                return null;
            }
            return ToModel(rows[0]);
        }
        //通过名字查询
        public Person[] SearchByName(String name)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON WHERE NAME LIKE '%'+@NAME+'%'",
                new SqlParameter("@NAME", name));

            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;

            Person [] person = new Person[count];
            for (int i = 0; i < count;i++ )
            {
                person[i] = ToModel(rows[i]);
            }

            return person;
        }

        
        
        public Person[] SearchByLimit(string LIMIT)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON WHERE LIMITES=@LIMIT",
                new SqlParameter("@LIMIT", LIMIT));

            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;

            Person[] person = new Person[count];
            for (int i = 0; i < count; i++)
            {
                person[i] = ToModel(rows[i]);
            }

            return person;
        }

        public Person[] SearchByState(string state)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON WHERE State=@state",
                new SqlParameter("@LIMIT", state));
            if (table == null)
                return null;

            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;

            Person[] person = new Person[count];
            for (int i = 0; i < count; i++)
            {
                person[i] = ToModel(rows[i]);
            }

            return person;
        }

        //通过银行卡信息查询
        public Person SearchByBankNumber(String BankNumber)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON WHERE BANKNUMBER=@BANKNUMBER",
               new SqlParameter("@BANKNUMBER", SqlHelper.ToDbValue(BankNumber)));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
            {
                return null;
            }
            return ToModel(rows[0]);
        }

        

        public int UpdateImage(byte[] Photo, string id)
        {
            SqlParameter photoPara = new SqlParameter("@PHOTO", SqlHelper.ToDbValue(Photo));
            photoPara.SqlDbType = SqlDbType.Image;
            return SqlHelper.ExecuteNonQuery(@"UPDATE PERSON SET PHOTO=@PHOTO WHERE ID=@ID",photoPara,new SqlParameter("@ID",id));
        }
        //更改基本信息
        public int Update(Person person)
        {
            SqlParameter photoPara = new SqlParameter("@PHOTO", SqlHelper.ToDbValue(person.Photo));
            photoPara.SqlDbType = SqlDbType.Image;
            return SqlHelper.ExecuteNonQuery(@"UPDATE PERSON SET Name=@Name,Passwd=@Passwd,
                BankNumber=@BankNumber,TelNumber=@TelNumber,MailNumber=@MailNumber,Salary=@Salary,
                FinnalSalary=@FinnalSalary,Photo=@Photo,Limites=@Limit ,Birthday=@Birthday,Nation=@Nation,
                Sex=@Sex,Address=@Address,Department=@Department,Office=@Office,Specialty=@Specialty,School=@School,
                Entrytime=@Entrytime,State=@State,EduBackGround=@EduBackGround,Resume=@Resume,Remark=@Remark,HomeTown=@HomeTown,Major=@Major,BankName=@BankName where ID = @ID", new SqlParameter("@Name", person.Name)
                                                                                    , new SqlParameter("@Passwd", person.Passwd)
                                                                                    , new SqlParameter("@BankNumber", person.BankNumber)
                                                                                    , new SqlParameter("@TelNumber", SqlHelper.ToDbValue(person.TelNumber))
                                                                                    , new SqlParameter("@MailNumber", SqlHelper.ToDbValue(person.MailNumber))
                                                                                    , new SqlParameter("@Salary", person.Salary)
                                                                                    , new SqlParameter("@FinnalSalary", person.FinalSalary)
                                                                                    , photoPara
                                                                                    , new SqlParameter("@Limit", person.Limit)
                                                                                    , new SqlParameter("@Birthday", SqlHelper.ToDbValue(person.Birthday))
                                                                                    , new SqlParameter("@Nation", SqlHelper.ToDbValue(person.Nation))
                                                                                    , new SqlParameter("@Sex", SqlHelper.ToDbValue(person.Sex))
                                                                                    , new SqlParameter("@Address", SqlHelper.ToDbValue(person.Address))
                                                                                    , new SqlParameter("@Department", SqlHelper.ToDbValue(person.Department))
                                                                                    , new SqlParameter("@Office",SqlHelper.ToDbValue(person.Office))
                                                                                    , new SqlParameter("@Specialty", SqlHelper.ToDbValue(person.Specialty))
                                                                                    , new SqlParameter("@School", SqlHelper.ToDbValue(person.School))
                                                                                    , new SqlParameter("@Entrytime", SqlHelper.ToDbValue(person.Entrytime))
                                                                                    , new SqlParameter("@State", SqlHelper.ToDbValue(person.State))
                                                                                    , new SqlParameter("@EduBackGround", SqlHelper.ToDbValue(person.EduBackGround))
                                                                                    , new SqlParameter("@Resume", SqlHelper.ToDbValue(person.Resume))
                                                                                    , new SqlParameter("@Remark", SqlHelper.ToDbValue(person.Remark))
                                                                                    , new SqlParameter("@HomeTown", SqlHelper.ToDbValue(person.HomeTown))
                                                                                    , new SqlParameter("@Major", SqlHelper.ToDbValue(person.Major))
                                                                                    , new SqlParameter("@BankName", SqlHelper.ToDbValue(person.BankName))
                                                                                    , new SqlParameter("@ID", person.ID));
        }

        public int AlterPasswd(String id,String oldPasswd,String newPasswd)
        {

            return SqlHelper.ExecuteNonQuery(@"UPDATE PERSON SET Passwd=@newPasswd where ID =@id and Passwd=@oldPasswd", new SqlParameter("@newPasswd",newPasswd)
                , new SqlParameter("@id", id)
                , new SqlParameter("@oldPasswd",oldPasswd));
        }

        public int AlterSalary(String id,float newSa)
        {
            return SqlHelper.ExecuteNonQuery(@"update person Set salary=@salary where id =@id"
                ,new SqlParameter("@salary",newSa)
                , new SqlParameter("@id", id));
        }

        public Person[] ListAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM PERSON");

            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            
            if (count == 0)
            {
                return null;
            }

            Person[] person = new Person[count];
            for (int i = 0; i < count; i++)
            {
                person[i] = ToModel(rows[i]);
            }

            return person;
        }


    }
}
