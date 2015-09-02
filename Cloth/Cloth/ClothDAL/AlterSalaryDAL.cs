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
    public class AlterSalaryDAL
    {
        public MAlterSalary ToModel(DataRow row)
        {
            if (row == null)
            {
                return null;
            }

            MAlterSalary ma = new MAlterSalary();
            ma.ID = (String)row["personid"];
            ma.PersonName = (String)SqlHelper.FromDbValue(row["personName"]);
            ma.OldSalary = Convert.ToSingle(row["oldSalary"]);
            ma.NewSalary = Convert.ToSingle(row["newSalary"]);
            ma.Time = Convert.ToDateTime(row["time"]);
            ma.Reason =(String) SqlHelper.FromDbValue(row["reason"]);

            return ma;
        }

        public int Insert(MAlterSalary ma)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into AlterSalary(personid,personname,time,oldSalary,newSalary,reason)
                                      values(@id,@personname,@time,@oldSalary,@newSalary,@reason)",new SqlParameter("@id",ma.ID)
                                                                                                  , new SqlParameter("@personname", SqlHelper.FromDbValue(ma.PersonName))
                                                                                      , new SqlParameter("@time", ma.Time)
                                                                                      , new SqlParameter("@oldSalary", ma.OldSalary)
                                                                                      , new SqlParameter("@newSalary", ma.NewSalary)
                                                                                      , new SqlParameter("@reason", SqlHelper.ToDbValue(ma.Reason)));
        }

        public int Delete(string id,DateTime time)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from AlterSalary where personid=@id and time=@time",new SqlParameter("@id",id)
                , new SqlParameter("@time", time));
        }

        public int Delete(string id)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from AlterSalary where personid=@id", new SqlParameter("@id", id));
        }

        public MAlterSalary [] Search(string id)
        {
            DataTable dt = SqlHelper.ExecuteDataTable(@"select * from AlterSalary where personid=@id order by time desc",new SqlParameter("@id",id));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            MAlterSalary[] ma = new MAlterSalary[count];
            for (int i = 0; i < count; i++)
            {
                ma[i] = ToModel(rows[i]);
            }
            return ma;
        }

        /// <summary>
        ///  查询出一个人某月更改后的工资  “这个函数计算有问题”
        /// </summary>
        /// <param name="id">身份证</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <returns>工资</returns>
        public float SearchSalary(string id,int year,int month)
        {
            DataTable dt = SqlHelper.ExecuteDataTable(@"select * from AlterSalary where personid=@id and year(time)=@year and month(time)=@month
                                                      order by time desc",new SqlParameter("@id",id)
                                                                         , new SqlParameter("@year", year)
                                                                         , new SqlParameter("@month", month));
            if (dt.Rows.Count == 0)
            {
                MAlterSalary[] mas = Search(id);
                if (mas == null)    //说明工资从来没变过
                    return -1;
                return mas[0].NewSalary;       //返回最近修改记录即可
            }
            MAlterSalary ma = ToModel(dt.Rows[0]);
            return ma.NewSalary;
            
        }

        public MAlterSalary [] ListAll()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from AlterSalary");
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            MAlterSalary[] ma = new MAlterSalary[count];
            for (int i = 0; i < count;i++)
            {
                ma[i] = ToModel(rows[i]);
            }
            return ma;
        }

    }
}
