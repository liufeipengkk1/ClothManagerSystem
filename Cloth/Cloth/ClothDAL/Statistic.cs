using ClothModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothDAL
{
    /// <summary>
    /// 该类用于统计管理:生成各种清单报表
    /// </summary>
    public class Statistic
    {
        /// <summary>
        ///  表：
        ///    身份证 | 姓名 || 基本工资 
        /// </summary>
        /// <param name="limit">员工权限</param>
        /// <returns>基本工资清单</returns>
        public DataTable GetSalaryList(string limit)
        {
            PersonDAL pd = new PersonDAL();
            Person [] persons = pd.SearchByLimit(limit);
            if (persons == null)
                return null;
            DataTable dt = new DataTable();
            dt.Columns.Add("身份证");
            dt.Columns.Add("姓名");
            dt.Columns.Add("基本工资");
            foreach(Person person in persons)
            {
                DataRow row = dt.NewRow();
                row["身份证"] = person.ID;
                row["姓名"] = person.Name;
                row["基本工资"] = person.Salary;
                dt.Rows.Add(row);
            }
            return dt;
        }
        /// <summary>
        ///  表： 
        ///     身份证 | 姓名 | 基本工资
        /// </summary>
        /// <returns>基本工资清单</returns>
        public DataTable GetSalaryList(int year,int month)
        {
            PersonDAL pd = new PersonDAL();
            Person[] persons = pd.ListAll();
            if (persons == null)
                return null;
            DataTable dt = new DataTable();
            dt.Columns.Add("身份证");
            dt.Columns.Add("姓名");
            dt.Columns.Add("基本工资");
            foreach (Person person in persons)
            {
                DataRow row = dt.NewRow();
                row["身份证"] = person.ID;
                row["姓名"] = person.Name;
                row["基本工资"] = GetPersonSalary(person.ID,year,month);
                dt.Rows.Add(row);
            }
            return dt;
        }

        /// <summary>
        ///  表： 
        ///     身份证 | 姓名 | 总工资
        /// </summary>
        /// <returns>基本工资清单</returns>
        public DataTable GetTotalSalaryList(int year, int month)
        {
            PersonDAL pd = new PersonDAL();
            Person[] persons = pd.ListAll();
            if (persons == null)
                return null;
            DataTable dt = new DataTable();
            dt.Columns.Add("身份证");
            dt.Columns.Add("姓名");
            dt.Columns.Add("基本工资");
            foreach (Person person in persons)
            {
                DataRow row = dt.NewRow();
                row["身份证"] = person.ID;
                row["姓名"] = person.Name;
                row["基本工资"] = GetPersonTotalSalary(person.ID, year, month);
                dt.Rows.Add(row);
            }
            return dt;
        }

        /// <summary>
        /// 表 ：
        ///     身份证 | 姓名  |  提成
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <returns>提成清单</returns>
        public DataTable GetTichengList(int year,int month)
        {
            PersonDAL pd = new PersonDAL();
            SaleSheetDAL sd = new SaleSheetDAL();
            Person[] persons = pd.ListAll();
            if (persons == null)
                return null;
            DataTable dt = new DataTable();
            dt.Columns.Add("身份证");
            dt.Columns.Add("姓名");
            dt.Columns.Add("提成");
            foreach (Person person in persons)
            {
                DataRow row = dt.NewRow();
                row["身份证"] = person.ID;
                row["姓名"] = person.Name;
                row["提成"] = sd.GetTheMonthTicheng(person.ID,year,month);
                dt.Rows.Add(row);
            }
            return dt;
        }

        /// <summary>
        /// 表： 
        ///   身份证 | 姓名 | 基本工资 | 提成 | 总工资
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public DataTable GetDetailSalary(int year, int month)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            DataTable dt = GetSalaryList(year, month);
            dt.Columns.Add("提成");
            dt.Columns.Add("总工资");
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                row["提成"] = sd.GetTheMonthTicheng((string)row["身份证"], year, month);
                row["总工资"] = Convert.ToSingle(row["基本工资"]) + Convert.ToSingle(row["提成"]);
            }
            return dt;
        }


        /// <summary>
        /// 获取月工资
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public float GetPersonSalary(string id,int year,int month)
        {
            AlterSalaryDAL asd = new AlterSalaryDAL();
            PersonDAL pd = new PersonDAL();
            Person person = pd.SearchById(id);
            float salary = asd.SearchSalary(id, year, month);
            if(salary == -1)        //更改记录并没有发现。说明没改过
            {
                return person.Salary;
            }
            else
            {
                return salary;
            }
        }

        /// <summary>
        /// 获取加上提成之后的总工资
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public float GetPersonTotalSalary(string id ,int year,int month)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            float baseSalary = GetPersonSalary(id, year, month);
            float ticheng = sd.GetTheMonthTicheng(id, year, month);
            return baseSalary + ticheng;
        }


        /// <summary>
        ///  表：
        ///     月份  |  工资
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetPersonSalaryList(string id,int year)
        {
            PersonDAL pd = new PersonDAL();
            Person person = pd.SearchById(id);
            if (person == null)
                return null;

            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("工资");
            for(int i = 1 ;i <= DateTime.Now.Month;i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["工资"] = GetPersonSalary(id, year, i);
                dt.Rows.Add(row);
            }

            return dt;
        }

        public DataTable GetPersonTiChengList(string id, int year)
        {
            PersonDAL pd = new PersonDAL();
            SaleSheetDAL sd = new SaleSheetDAL();
            Person person = pd.SearchById(id);
            if (person == null)
                return null;

            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("提成");
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["提成"] = sd.GetTheMonthTicheng(id, year, i);
                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        ///  表：
        ///     月份  |  总工资
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetPersonTotalSalaryList(string id, int year)
        {
            PersonDAL pd = new PersonDAL();
            Person person = pd.SearchById(id);
            if (person == null)
                return null;

            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("总工资");
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["总工资"] = GetPersonTotalSalary(id, year, i);
                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        ///  月销量
        ///    姓名 | 销量 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetPersonSoldNumber(string id, int year)
        {
            PersonDAL pd = new PersonDAL();
            Person person = pd.SearchById(id);
            SaleSheetDAL sd = new SaleSheetDAL();
            if (person == null)
                return null;

            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("销量");
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["销量"] = sd.GetTheSoldNumber(id, year, i);
                dt.Rows.Add(row);
            }

            return dt;
        }

        /// <summary>
        ///  表：
        ///     月份 | 销量
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetMonthSoldNumber(int year)
        { 
            SaleSheetDAL sd = new SaleSheetDAL();
            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("销量");
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["销量"] = sd.GetTheSoldNumber(year, i);
                dt.Rows.Add(row);
            }

            return dt;
        }
        
        /// <summary>
        ///  表：
        ///     月份 | 销售额
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetMonthSoldMoney(int year)
        {
            SaleSheetDAL sd = new SaleSheetDAL();
            DataTable dt = new DataTable();
            dt.Columns.Add("月份");
            dt.Columns.Add("销售额");
            for (int i = 1; i <= DateTime.Now.Month; i++)
            {
                DataRow row = dt.NewRow();
                row["月份"] = i;
                row["销售额"] = sd.GetSoldMoney(year, i);
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
