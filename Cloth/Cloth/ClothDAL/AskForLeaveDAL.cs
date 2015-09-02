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

    public class AskForLeaveDAL
    {
        public AskForLeave ToModel(DataRow row)
        {
            if (row == null)
                return null;
            AskForLeave leave = new AskForLeave();
            leave.ID = (String)row["id"];
            leave.Name = (String)row["name"];
            leave.Days = (int)row["days"];
            leave.Time = (DateTime)row["time"];
            leave.Reason = (String)SqlHelper.FromDbValue(row["reason"]);

            return leave;
        }

        public int Insert(AskForLeave leave)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into AskForLeave(ID,Name,days,Time,Reason) 
                    values(@ID,@Name,@days,@Time,@Reason)", new SqlParameter("@ID", leave.ID)
                                                    , new SqlParameter("@Name", leave.Name)
                                                    , new SqlParameter("@days", leave.Days)
                                                    , new SqlParameter("@Time", leave.Time)
                                                    , new SqlParameter("@Reason", SqlHelper.ToDbValue(leave.Reason)));
        }

        //删除某一次请假信息
        public int Delete(String id,DateTime dt) 
        {
            return SqlHelper.ExecuteNonQuery("delete from AskForLeave where ID=@ID and TIME=@TIME",
                new SqlParameter("@ID", id), new SqlParameter("@TIME", dt));
        }
        //删除某一人的所有请假信息
        public int Delete(String id)
        {
            return SqlHelper.ExecuteNonQuery("delete from AskForLeave where ID=@ID",
                 new SqlParameter("@ID", id));
        }

        public AskForLeave[] Search(string id)
        {
            DataTable dt = SqlHelper.ExecuteDataTable(@"select * from AskForLeave where id=@id order by time desc", new SqlParameter("@id", id));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            AskForLeave[] leave = new AskForLeave[count];
            for (int i = 0; i < count; i++)
            {
                leave[i] = ToModel(rows[i]);
            }
            return leave;
        }

        public int Clear()
        {
            return SqlHelper.ExecuteNonQuery("delete from AskForLeave") ;
        }

        public AskForLeave [] ListAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from AskForLeave");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            AskForLeave[] leave = new AskForLeave[count];
            for (int i = 0; i < count; i++)
            {
                leave[i] = ToModel(rows[i]);
            }
            return leave;
        }

        public void CheckLeave()
        {
            PersonDAL pd = new PersonDAL();
            Person [] persons = pd.SearchByState("休假");

            if (persons == null)
                return;
            foreach(Person person in persons)
            {
                AskForLeave[] afls = Search(person.ID);
                //判断最近一次请假
                DateTime dt = afls[0].Time;
                DateTime newDay = dt.AddDays(afls[0].Days);
                if(DateTime.Now > newDay)
                {
                    pd.AlterState(person.ID, "在职");
                }
                
            }
        }
    }
}
