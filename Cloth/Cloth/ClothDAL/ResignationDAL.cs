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
    public class ResignationDAL
    {
        public Resignation ToModel(DataRow row)
        {
            Resignation leave = new Resignation();
            leave.ID = (String)row["id"];
            leave.Name = (String)row["name"];
            leave.Time = (DateTime)row["time"];
            leave.Reason = (String)SqlHelper.FromDbValue(row["reason"]);

            return leave;
        }

        public int Insert(Resignation leave)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into Resignation(ID,Name,Time,Reason) 
                values(@ID,@Name,@Time,@Reason)",new SqlParameter("@ID",leave.ID)
                                                , new SqlParameter("@Name", leave.Name)
                                                , new SqlParameter("@Time", leave.Time)
                                                , new SqlParameter("@Reason", SqlHelper.ToDbValue(leave.Reason)));
        }

        public int Delete(String id, DateTime dt)
        {
            return SqlHelper.ExecuteNonQuery("delete from Resignation where ID=@ID,TIME=@TIME",
                 new SqlParameter("@ID", id), new SqlParameter("@TIME", dt));
        }


        public int Clear()
        {
            return SqlHelper.ExecuteNonQuery("delete from Resignation");
        }

        public Resignation [] ListAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from Resignation");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Resignation[] leave = new Resignation[count];
            for (int i = 0; i < count; i++)
            {
                leave[i] = ToModel(rows[i]);
            }
            return leave;
        }
    }
}
