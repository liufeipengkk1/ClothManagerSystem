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
    public class CClothDAL
    {
        public Cloth ToModel(DataRow row)
        {
            if (row == null)
                return null;
            Cloth cloth = new Cloth();
            cloth.ID = (String)row["id"];
            cloth.Style = (String)row["style"];
            cloth.Name = (String)row["name"];
            cloth.Color = (String)row["color"];
            cloth.Size = (String)row["size"];
            cloth.Price = Convert.ToSingle(row["price"]);
            cloth.SalePrice = Convert.ToSingle(row["saleprice"]);
            cloth.Profit = Convert.ToSingle(row["profit"]);
            cloth.SaleState = (String)row["salestate"];

            cloth.Logo = (byte[])SqlHelper.FromDbValue(row["logo"]);
            cloth.Standard = (String)SqlHelper.FromDbValue(row["standard"]);
            cloth.CheckCode = (String)SqlHelper.FromDbValue(row["checkcode"]);
            cloth.ClothLevel = (String)SqlHelper.FromDbValue(row["clothlevel"]);
            cloth.ManufacturerInfo = (String)SqlHelper.FromDbValue(row["manufacturerinfo"]);
            cloth.ImportTime = Convert.ToDateTime(SqlHelper.FromDbValue(row["importtime"]));
            
            return cloth;
        }


        public int InsertCloth(Cloth cloth) 
        {
            //无法自动识别photo这种数据项；
            SqlParameter photoPara = new SqlParameter("@Logo", SqlHelper.ToDbValue(cloth.Logo));
            photoPara.SqlDbType = SqlDbType.Image;
            return SqlHelper.ExecuteNonQuery(@"INSERT INTO CLOTH(ID,Style,Name,Color,Size,Price,
                    SalePrice,Profit,SaleState,Logo,Standard,CheckCode,ClothLevel,ManufacturerInfo,importtime) VALUES(@ID,@Style,@Name,@Color,@Size,@Price,
                    @SalePrice,@Profit,@SaleState,@Logo,@Standard,@CheckCode,@ClothLevel,@ManufacturerInfo,@importtime)", new SqlParameter("@ID", cloth.ID)
                                                                                                            , new SqlParameter("@Style", cloth.Style)
                                                                                                            , new SqlParameter("@Name", cloth.Name)
                                                                                                            , new SqlParameter("@Color", cloth.Color)
                                                                                                            , new SqlParameter("@Size", cloth.Size)
                                                                                                            , new SqlParameter("@Price", cloth.Price)
                                                                                                            , new SqlParameter("@SalePrice", cloth.SalePrice)
                                                                                                            , new SqlParameter("@Profit", cloth.Profit)
                                                                                                            , new SqlParameter("@SaleState", cloth.SaleState)
                                                                                                            , photoPara
                                                                                                            , new SqlParameter("@Standard", SqlHelper.ToDbValue(cloth.Standard))
                                                                                                            , new SqlParameter("@CheckCode", SqlHelper.ToDbValue(cloth.CheckCode))
                                                                                                            , new SqlParameter("@ClothLevel", SqlHelper.ToDbValue(cloth.ClothLevel))
                                                                                                            , new SqlParameter("@ManufacturerInfo",SqlHelper.ToDbValue(cloth.ManufacturerInfo))
                                                                                                            ,new SqlParameter("@importtime",DateTime.Now));
        }

        public int DeleteClothById(String id)
        {
            return SqlHelper.ExecuteNonQuery(@"DELETE FROM CLOTH WHERE ID=@ID",new SqlParameter("@ID",id));
        }

        public Cloth [] SearchByName(String name)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"SELECT * FROM CLOTH WHERE NAME LIKE '%@NAME%'",
               new SqlParameter("@NAME", name)); 
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth [] cloth = new Cloth[count];
            for (int i = 0; i < count;i++ )
            {
                cloth[i] = ToModel(rows[i]);
            }

            return cloth;
        }

        public Cloth SearchById(String id)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where id = @id",new SqlParameter("@id",id));
            if (table == null)
                return null;
            if(table.Rows.Count == 0)
            { 
                return null; 
            }
            return ToModel(table.Rows[0]);
        }

        public Cloth[] SearchByStyle(String Style)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where style = @style", new SqlParameter("@style", Style));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Cloth [] cloth = new Cloth[count];
            for (int i = 0; i < count;i++ )
            {
                cloth[i] = ToModel(rows[i]);
            }
            return cloth;
        }

        public Cloth [] SearchBySize(string size)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where size = @size", new SqlParameter("@size", size));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Cloth[] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                cloth[i] = ToModel(rows[i]);
            }
            return cloth;
        }

        public Cloth[] SearchByColor(string color)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where color = @color", new SqlParameter("@color", color));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Cloth[] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                cloth[i] = ToModel(rows[i]);
            }
            return cloth;
        }

        public Cloth[] SearchByState(string state)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where salestate = @state", new SqlParameter("@state", state));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            if (count == 0)
                return null;
            Cloth[] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
            {
                cloth[i] = ToModel(rows[i]);
            }
            return cloth;
        }

        //更新衣服信息
        public int Update(Cloth cloth)
        {
            SqlParameter photoPara = new SqlParameter("@Logo", SqlHelper.ToDbValue(cloth.Logo));
            photoPara.SqlDbType = SqlDbType.Image;
            return SqlHelper.ExecuteNonQuery(@"UPDATE CLOTH SET Style=@Style,Name=@Name,
            Color=@Color,Size=@Size,Price=@Price,SalePrice=@SalePrice,Profit=@Profit,SaleState=@SaleState,
            Logo=@Logo,Standard=@Standard,CheckCode=@CheckCode,ClothLevel=@ClothLevel,
            ManufacturerInfo=@ManufacturerInfo WHERE ID=@ID", new SqlParameter("@Style", cloth.Style)
                                                            , new SqlParameter("@Name", cloth.Name)
                                                            , new SqlParameter("@Color", cloth.Color)
                                                            , new SqlParameter("@Size", cloth.Size)
                                                            , new SqlParameter("@Price", cloth.Price)
                                                            , new SqlParameter("@SalePrice", cloth.SalePrice)
                                                            , new SqlParameter("@Profit", cloth.Profit)
                                                            , new SqlParameter("@SaleState", cloth.SaleState)
                                                            , photoPara
                                                            , new SqlParameter("@Standard", SqlHelper.ToDbValue(cloth.Standard))
                                                            , new SqlParameter("@CheckCode", SqlHelper.ToDbValue(cloth.CheckCode))
                                                            , new SqlParameter("@ClothLevel", SqlHelper.ToDbValue(cloth.ClothLevel))
                                                            , new SqlParameter("@ManufacturerInfo", SqlHelper.ToDbValue(cloth.ManufacturerInfo))
                                                            , new SqlParameter("@ID", cloth.ID));
        }
    

        

       //更改销售状态
        public int AlterSaleState(string id,string salestate)
        {
            return SqlHelper.ExecuteNonQuery(@"update cloth set SaleState=@SaleState where ID=@ID", new SqlParameter("@SaleState", salestate),
                new SqlParameter("@ID",id));
        }

        public int AlterSalePrice(String id,float price)
        {
            return SqlHelper.ExecuteNonQuery(@"update cloth set salePrice=@salePrice where ID=@ID", new SqlParameter("@salePrice", price),
                new SqlParameter("@ID", id));
        }


        public int WriteProfit(String id) 
        {
            DataTable table = SqlHelper.ExecuteDataTable("select * from cloth where id=@id",new SqlParameter("@id",id));
            Cloth cloth = ToModel(table.Rows[0]);
            return SqlHelper.ExecuteNonQuery("update cloth set Profit=@Profit where ID = @ID", new SqlParameter("@Profit", cloth.Profit),
                new SqlParameter("@ID", cloth.ID));
        }

        
        
        public Cloth [] ListImportCloth(int year,int month ,int day,string salestate)
        {
            DataTable dt;
            if(salestate == null)
            {
                dt = SqlHelper.ExecuteDataTable(@"select * from cloth where year(importtime)=@year and month(importtime)=@month and day(importtime)=@day"
                , new SqlParameter("@year", year)
                , new SqlParameter("@month", month)
                , new SqlParameter("@day", day));
            }
            else
            {
                dt = SqlHelper.ExecuteDataTable(@"select * from cloth where year(importtime)=@year and month(importtime)=@month and day(importtime)=@day and salestate=@salestate"
                , new SqlParameter("@year", year)
                , new SqlParameter("@month", month)
                , new SqlParameter("@day", day)
                , new SqlParameter("@salestate", salestate));
            }
            DataRowCollection rows = dt.Rows;
            if (rows.Count == 0)
                return null;
            int count = rows.Count;
            Cloth [] clothes = new Cloth[rows.Count];
            for(int i = 0 ;i <count;i++)
            {
                clothes[i] = ToModel(rows[i]);
            }

            return clothes;
        }

        public Cloth [] ListAll()
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth");
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth [] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
                cloth[i] = ToModel(rows[i]);
            return cloth;
        }

        public Cloth [] ListSaleStateCloth(string salestate)
        {
            DataTable table = SqlHelper.ExecuteDataTable(@"select * from cloth where salestate =@salestate order by importtime asc",new SqlParameter("@salestate",salestate));
            DataRowCollection rows = table.Rows;
            int count = rows.Count;
            Cloth[] cloth = new Cloth[count];
            for (int i = 0; i < count; i++)
                cloth[i] = ToModel(rows[i]);
            return cloth;
        }

        public DataTable ListAllStyle()
        {
            DataTable td = SqlHelper.ExecuteDataTable("select distinct style from cloth");
            return td;
        }

        public DataTable ListAllSize()
        {
            DataTable td = SqlHelper.ExecuteDataTable("select distinct size from cloth");
            return td;
        }

        public DataTable ListAllColor()
        {
            DataTable td = SqlHelper.ExecuteDataTable("select distinct color from cloth");
            return td;
        }

        public DataTable ListImportTime()
        {
            DataTable td = SqlHelper.ExecuteDataTable("select distinct CONVERT(varchar(10),importtime,111) as importtime from cloth ");
            return td;
        }
    }

    
}
