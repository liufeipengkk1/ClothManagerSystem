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
    public class ActivityDAL
    {
        /// <summary>
        ///  数据库模型转化为对象实例
        /// </summary>
        /// <param name="row"></param>
        /// <returns>Activity对象</returns>
        public Activity ToModel(DataRow row)
        {
            if (row == null)
                return null;
            Activity at = new Activity();
            at.Name = (String)(row["name"]);
            at.StartTime = Convert.ToDateTime(SqlHelper.FromDbValue(row["starttime"]));
            at.EndTime = Convert.ToDateTime(SqlHelper.FromDbValue(row["endtime"]));
            at.ActivityContent = (String)SqlHelper.FromDbValue(row["activitycontent"]);

            return at;
        }

        /// <summary>
        /// 插入活动
        /// </summary>
        /// <param name="ac"></param>
        /// <returns></returns>
        public int Insert(Activity ac)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into activity(name,starttime,endtime,activityContent) 
                                               values(@name,@starttime,@endtime,@activityContent)"
                                               ,new SqlParameter("@name",ac.Name)
                                               , new SqlParameter("@starttime", ac.StartTime)
                                               , new SqlParameter("@endtime", ac.EndTime)
                                               , new SqlParameter("@activityContent", ac.ActivityContent));
        }

        public bool IsOverLap(DateTime start,DateTime end)
        {
            Activity[] acs = ListMonth(start);
            return false;
        }

        /// <summary>
        /// 编辑活动
        /// </summary>
        /// <param name="ac"></param>
        /// <returns></returns>
        public int UpdateActivity(Activity ac)
        {
            return SqlHelper.ExecuteNonQuery(@"Update activity set starttime=@start,endtime=@end,activitycontent=@content
             where Name=@name", new SqlParameter("@start",ac.StartTime)
                              , new SqlParameter("@end", ac.EndTime)
                              , new SqlParameter("@content", SqlHelper.ToDbValue(ac.ActivityContent))
                              , new SqlParameter("@name", ac.Name));
        }

        /// <summary>
        /// 想某次活动插入活动服装
        /// </summary>
        /// <param name="activityName"></param>
        /// <param name="clothID"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public int InsertClothToActivity(String activityName,String clothID,float price)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into ActivityCloth(activityName,clothID,saleprice) values(@activityName,@clothID,@saleprice)"
                                              ,new SqlParameter("@activityName",activityName)
                                              , new SqlParameter("@clothID", clothID)
                                              , new SqlParameter("@saleprice", price));
        }

        /// <summary>
        /// 修改活动商品价格 
        /// </summary>
        /// <param name="clothid"></param>
        /// <param name="saleprice"></param>
        /// <returns></returns>
        public int ModifyTheSalePrice(string clothid,float saleprice)
        {
            return SqlHelper.ExecuteNonQuery(@"update activityCloth Set saleprice=@saleprice where clothid=@clothid"
                                            ,new SqlParameter("@saleprice",saleprice)
                                            , new SqlParameter("@clothid", clothid));
        }

        /// <summary>
        /// 获取活动商品的价格 若活动已经过期，则返回0
        /// </summary>
        /// <param name="clothid"></param>
        /// <returns></returns>
        public float GetTheSalePrice(string clothid)
        {
            Object result = SqlHelper.ExecuteScalar(@"select saleprice from ActivityCloth,Activity where ActivityCloth.ActivityName =  Activity.Name 
                                                     and clothid=@clothid and starttime <=@time and endtime >=@time"
                                                    ,new SqlParameter("@clothid",clothid)
                                                    , new SqlParameter("@time", DateTime.Now));
            if (SqlHelper.FromDbValue(result) == null)
                return 0;
            else
            {
                return Convert.ToSingle(result);
            }
        }

        /// <summary>
        /// 获取活动期间商品实际价格:
        /// </summary>
        /// <param name="clothid"></param>
        /// <returns></returns>
        public float GetTheActivitySalePrice(string clothid)
        {
            Object result = SqlHelper.ExecuteScalar(@"select saleprice from ActivityCloth,Activity where ActivityCloth.ActivityName =  Activity.Name 
                                                     and clothid=@clothid"
                                                    , new SqlParameter("@clothid", clothid));
            return Convert.ToSingle(result);
        }

        /// <summary>
        /// 搜索活动
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public Activity Search(String Name)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from activity where name=@activityName", new SqlParameter("@activityName", Name));
            if (dt.Rows.Count == 0)
                return null;
            Activity ac = ToModel(dt.Rows[0]);
            return ac;
        }

        /// <summary>
        /// 删除活动服装
        /// </summary>
        /// <param name="clothid"></param>
        /// <returns></returns>
        public int DeleteClothFromActivity(String clothid)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from activityCloth where clothid=@clothid", new SqlParameter("@clothid", clothid));
        }

        /// <summary>
        /// 删除活动服装
        /// </summary>
        /// <param name="activityName"></param>
        /// <returns></returns>
        public int DeleteActivityCloth(String activityName)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from activityCloth where ActivityName=@activityName", new SqlParameter("@activityName", activityName));
        }

        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="activityName"></param>
        /// <returns></returns>
        public int DeleteActivity(String activityName)
        {
            SqlHelper.ExecuteNonQuery(@"delete from activityCloth where activityName=@activityName",new SqlParameter("@activityName",activityName));
            return SqlHelper.ExecuteNonQuery(@"delete from activity where name=@activityName",new SqlParameter("@activityName",activityName));
        }

        /// <summary>
        /// 获取活动商品
        /// </summary>
        /// <param name="activityName"></param>
        /// <returns></returns>
        public Cloth[] ListActivityCloth(string activityName)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select clothid from ActivityCloth where activityName = @activityName"
                                                      , new SqlParameter("@activityName", activityName));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Cloth[] clothes = new Cloth[count];
            CClothDAL cd = new CClothDAL();
            for (int i = 0; i < count; i++)
            {
                clothes[i] = cd.SearchById((string)rows[i]["clothid"]);
            }

            return clothes;
        }

        /// <summary>
        /// 列出正在进行的活动
        /// </summary>
        /// <param name="time"></param>
        /// <returns>Activity数组</returns>
        public Activity [] ListBeing(DateTime time)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from Activity where starttime <= @time and endtime>=@time  order by endtime desc"
                                                      ,new SqlParameter("@time",time));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Activity[] ac = new Activity[count];
            for (int i = 0; i < count; i++)
            {
                ac[i] = ToModel(rows[i]);
            }

            return ac;
        }

        public Activity[] ListMonth(DateTime time)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from Activity where endtime >=@time"
                                                      , new SqlParameter("@time", time));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Activity[] ac = new Activity[count];
            for (int i = 0; i < count; i++)
            {
                ac[i] = ToModel(rows[i]);
            }

            return ac;
        }

        public Activity[] ListHistory(DateTime start,DateTime end)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from Activity where starttime >= @start and endtime<=@end  order by endtime desc"
                                                      , new SqlParameter("@start", start)
                                                      , new SqlParameter("@end", end));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Activity[] ac = new Activity[count];
            for (int i = 0; i < count; i++)
            {
                ac[i] = ToModel(rows[i]);
            }

            return ac;
        }

        //获取所有活动
        public Activity [] ListAll()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from Activity order by endtime desc");
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Activity [] ac = new Activity[count];
            for(int i = 0;i < count;i++)
            {
                ac[i] = ToModel(rows[i]);
            }

            return ac;
        }

        //判断服装销售是否在某次活动内销售
        public bool SaleInActivity(string clothid,string activityName,DateTime start,DateTime end)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            DateTime time = sd.GetTheSoldDateTime(clothid);
            if (start <= time && end >= time)
                return true;
            return false;
        }
    }
}
