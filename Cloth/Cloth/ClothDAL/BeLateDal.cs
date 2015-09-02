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
    public class BeLateDal
    {
        public BeLate ToModel(DataRow row)
        {
            BeLate b_late = new BeLate();
            b_late.ID = (String)row["id"];
            b_late.Name = (String)row["name"];
            b_late.Time = (DateTime)row["time"];
            b_late.Reason = (String)SqlHelper.FromDbValue(row["Reason"]);
            return b_late;
        }

        public int Insert(BeLate b_late)
        {

            return SqlHelper.ExecuteNonQuery(@"insert into BeLate(ID,Name,Time,Reason) 
                    values(@ID,@Name,@Time,@Reason)", new SqlParameter("@ID", b_late.ID)
                                                    , new SqlParameter("@Name", b_late.Name)
                                                    , new SqlParameter("@Time", b_late.Time)
                                                    , new SqlParameter("@Reason", SqlHelper.ToDbValue(b_late.Reason)));
        }

        public int Delete(String id, DateTime dt)
        {
            return SqlHelper.ExecuteNonQuery("delete from BeLate where ID=@ID,TIME=@TIME",
                new SqlParameter("@ID",id),new SqlParameter("@TIME",dt));
        }

        public int Delete(String id)
        {
            return SqlHelper.ExecuteNonQuery("delete from BeLate where ID=@ID",
                 new SqlParameter("@ID", id));
        }

        public int Clear()
        {
            return SqlHelper.ExecuteNonQuery("delete from BeLate");
        }

        public BeLate[] ListAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from BeLate");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            BeLate [] b_late = new BeLate[count];
            for (int i = 0; i < count;i++ )
            {
                b_late[i] = ToModel(rows[i]);
            }
            return b_late;
        }
    }
}

