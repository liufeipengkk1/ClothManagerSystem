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
    public class SaleSheetDAL
    {
        public SaleSheet ToModel(DataRow row)
        {
            if (row == null)
                return null;

            SaleSheet ss = new SaleSheet();
            ss.SalePersonID = (String)row["personid"];
            ss.ClothID = (String)row["CLOTHID"];
            ss.SaleTime = Convert.ToDateTime(row["saletime"]);
            ss.Ticheng = Convert.ToSingle(row["ticheng"]);

            return ss;
        }

        public int Insert(SaleSheet saleSheet)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into SALE_SHEET(personid,clothid,saletime,ticheng) values(@personid,
                    @clothid,@saletime,@ticheng)", new SqlParameter("@personid", saleSheet.SalePersonID)
                                        , new SqlParameter("@clothid", saleSheet.ClothID)
                                        , new SqlParameter("@saletime", saleSheet.SaleTime)
                                        , new SqlParameter("@ticheng", saleSheet.Ticheng));
        }

        public int Insert(string personid,string clothid,float tc)
        {
            return SqlHelper.ExecuteNonQuery(@"insert into SALE_SHEET(personid,clothid,saletime,ticheng) values(@personid,
                    @clothid,@saletime,@ticheng)", new SqlParameter("@personid", personid)
                                        , new SqlParameter("@clothid", clothid)
                                        , new SqlParameter("@saletime", DateTime.Now.ToString())
                                        , new SqlParameter("@ticheng", tc));
        }

        public int Delete(SaleSheet saleSheet)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from SALE_SHEET where personid=@personid and clothid =@clothid"
                                        , new SqlParameter("@personid", saleSheet.SalePersonID)
                                        , new SqlParameter("@clothid", saleSheet.ClothID));
        }
        public int Delete(string personid, string clothid)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from SALE_SHEET where personid=@personid and clothid =@clothid"
                                        , new SqlParameter("@personid", personid)
                                        , new SqlParameter("@clothid", clothid));
        }
        public int Delete(string clothid)
        {
            return SqlHelper.ExecuteNonQuery(@"delete from SALE_SHEET where clothid =@clothid"
                                        , new SqlParameter("@clothid", clothid));
        }

        //获取一个人的所有提成
        public float GetTheTotalTiCheng(string id)
        {
            Object result = SqlHelper.ExecuteScalar("Select sum(TiCheng) from SALE_SHEET where personid=@id", new SqlParameter("@id", id));
            return Convert.ToSingle(SqlHelper.FromDbValue(result));
        }

        public float GetTheMonthTicheng(string id,int year,int month)
        {
            Object result = (SqlHelper.ExecuteScalar(@"Select sum(TiCheng) from SALE_SHEET where YEAR(SALETIME)=@year and MONTH(saletime)=@month and personid=@personid"
                                                    , new SqlParameter("@personid", id)
                                                    , new SqlParameter("@year", year)
                                                    , new SqlParameter("@month", month)));
            return Convert.ToSingle(SqlHelper.FromDbValue(result));
        }

        public float GetTheYearTiCheng(string id,int year)
        {
            Object result = (SqlHelper.ExecuteScalar(@"Select sum(TiCheng) from SALE_SHEET where YEAR(SALETIME)=@year and personid=@personid"
                                                    , new SqlParameter("@personid", id)
                                                    , new SqlParameter("@year", year)));
            return Convert.ToSingle(SqlHelper.FromDbValue(result));
        }

        public float GetTheClothTiCheng(string clothid)
        {
            Object result = (SqlHelper.ExecuteScalar("Select TiCheng from SALE_SHEET where clothid=@id", new SqlParameter("@id", clothid)));
            return Convert.ToSingle(SqlHelper.FromDbValue(result));
        }

        /// <summary>
        /// 获取某个人一共销售了多少件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetTheSoldNumber(string id)
        {
            Object result = (SqlHelper.FromDbValue(SqlHelper.ExecuteScalar(@"select count(personid) from SALE_SHEET WHERE PERSONID=@ID",
                new SqlParameter("@ID",id))));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// 获取某个人某个月销售了多少件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public int GetTheSoldNumber(string id,int year,int month)
        {
            Object result = (SqlHelper.FromDbValue(SqlHelper.ExecuteScalar(@"select count(personid) from SALE_SHEET 
                                                                             WHERE PERSONID=@ID and YEAR(SALETIME)=@year and MONTH(saletime)=@month"
                                                                             , new SqlParameter("@ID", id)
                                                                             , new SqlParameter("@year", year)
                                                                             , new SqlParameter("@month", month))));

            return Convert.ToInt32(result);
        }


        //列举出某个人卖的衣服
        public Cloth [] ListTheCloth(string id)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from SALE_SHEET WHERE PERSONID=@ID order by saletime desc",new SqlParameter("@ID",id));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            
            CClothDAL cd = new CClothDAL();
            Cloth[] cloth = new Cloth[count];
            for(int i = 0;i < count;i++)
            {
                cloth[i] = cd.SearchById(Convert.ToString(rows[i]["clothid"]));
            }

            return cloth;
        }

        public Cloth[] ListTheCloth(string id, int year, int month)
        {
            DataTable dt = SqlHelper.ExecuteDataTable(@"select * from SALE_SHEET WHERE PERSONID=@ID and YEAR(SALETIME)=@year and MONTH(saletime)=@month"
                , new SqlParameter("@ID", id)
                , new SqlParameter("@year", year)
                , new SqlParameter("@month", month));
            DataRowCollection rows = dt.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;

            CClothDAL cd = new CClothDAL();
            Cloth[] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                cloth[i] = cd.SearchById(Convert.ToString(rows[i]["clothid"]));
            }

            return cloth;
        }

      

        public DateTime GetTheSoldDateTime(string clothid)
        {
           Object result = SqlHelper.ExecuteScalar("select Saletime from SALE_SHEET where clothid = @clothid", new SqlParameter("@clothid", clothid));
           return Convert.ToDateTime(SqlHelper.FromDbValue(result));

        }


        // 最佳业绩销售员排行榜 此处需要更正
        public Person [] ListBestSaler()
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select PERSONID ,COUNT(PERSONID) as total from SALE_SHEET group by SALE_SHEET.PERSONID order by total desc");

            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Person[] person = new Person[count];
            PersonDAL cld = new PersonDAL();
            for (int i = 0; i < count; i++)
            {
                person[i] = cld.ToModel(rows[i]);
            }
            return person;
        }
        
        //某时间内最佳业绩销售员排行榜,比如说一周内 此处需要更正
        public Person [] ListBestSaler(string time)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select PERSONID ,COUNT(PERSONID) as total from SALE_SHEET group by SALE_SHEET.PERSONID order by total desc");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Person[] person = new Person[count];
            PersonDAL cld = new PersonDAL();
            for (int i = 0; i < count; i++)
            {
                person[i] = cld.ToModel(rows[i]);
            }
            return person;
        }

        public Person GetThePerson(string clothid)
        {
            Object result = SqlHelper.ExecuteScalar("Select PERSONID from SALE_SHEET where clothid=@id", new SqlParameter("@id", clothid));
            if (SqlHelper.FromDbValue(result) == null)
                return null;
            PersonDAL pd = new PersonDAL();
            return pd.SearchById((string)result);
            
        }

        public Cloth [] ListSoldCloth(DateTime start,DateTime end)
        {
            CClothDAL cd = new CClothDAL();
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from SALE_SHEET where  saletime>=@start and saletime <=@end"
                , new SqlParameter("@start", start)
                , new SqlParameter("@end", end));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth[] clothes = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                clothes[i] = cd.SearchById((String)rows[i]["CLOTHID"]);
            }

            return clothes;
        }

        public Cloth[] ListSoldCloth()
        {
            CClothDAL cd = new CClothDAL();
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from SALE_SHEET");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth[] clothes = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                clothes[i] = cd.SearchById((String)rows[i]["CLOTHID"]);
            }

            return clothes;
        }

        public float GetSoldMoney(int year,int month)
        {
            CClothDAL cd = new CClothDAL();
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from SALE_SHEET where  year(saletime)=@year and month(saletime)=@month"
                , new SqlParameter("@year", year)
                , new SqlParameter("@month", month));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth[] clothes = new Cloth[count];
            float result = 0;
            for (int i = 0; i < count; i++)
            {
                clothes[i] = cd.SearchById((String)rows[i]["CLOTHID"]);
                result += clothes[i].SalePrice;
            }

            return result;
        }

        public int GetTheSoldNumber(int year,int month)
        {
            Object result = SqlHelper.ExecuteScalar(@"select count(*) from SALE_SHEET where  year(saletime)=@year and month(saletime)=@month"
                , new SqlParameter("@year", year)
                , new SqlParameter("@month", month));

            return Convert.ToInt32(SqlHelper.FromDbValue(result));
        }

        /// <summary>
        /// 这个函数有待讨论  看是否做成利润曲线的形式
        /// </summary>
        /// <returns></returns>
        public float GetTheTotalProfit()
        {
            float profit = Convert.ToSingle(SqlHelper.ExecuteScalar("select sum(profit) from cloth where salestate = 'sold' "));
            return profit;
        }

        public DataTable ListSaleYear()
        {
            DataTable td = SqlHelper.ExecuteDataTable("select distinct datepart(year,saletime) as year from SALE_SHEET ");
            return td;
        }
    }
}
