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
    public class TiChengDAL
    {
        public MTiCheng ToModel(DataRow row)
        {
            if (row == null)
                return null;
            MTiCheng tc = new MTiCheng();
            tc.Name = (String)row["name"];
            tc.Ways = (WAY)row["Ways"];
            tc.Up = Convert.ToSingle(row["Up"]);
            tc.Down = Convert.ToSingle(row["Down"]);
            tc.Money = Convert.ToSingle(row["Money"]);

            return tc;
        }

        public int Insert(MTiCheng tc)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into ticheng(Name,Ways,down,up,money) 
                    values(@Name,@Ways,@down,@up,@money)", new SqlParameter("@Name", tc.Name)
                                                   , new SqlParameter("@Ways", tc.Ways)
                                                   , new SqlParameter("@down", tc.Down)
                                                   , new SqlParameter("@up", tc.Up)
                                                   , new SqlParameter("@money", tc.Money));
        }

        public int Update(MTiCheng tc)
        {
            return SqlHelper.ExecuteNonQuery(@"update TiCheng Set ways=@ways,up=@up,down=@down,money=@money where name=@name"
                ,new SqlParameter("@ways",tc.Ways)
                , new SqlParameter("@up", tc.Up)
                , new SqlParameter("@down", tc.Down)
                , new SqlParameter("@money", tc.Money)
                , new SqlParameter("@name", tc.Name));
        }

        public int Delete(string Name)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from ticheng where name=@name",new SqlParameter("@name",Name));
        }



        public MTiCheng [] ListAll()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from TiCheng");
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;

            MTiCheng[] tcs = new MTiCheng[count];
            for(int i = 0;i < count ;i++)
            {
                tcs[i] = ToModel(rows[i]);
            }

            return tcs;
        }
    }
}

