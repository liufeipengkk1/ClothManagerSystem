using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    //员工信息
    public class Person
    {
        public String ID {get;set; }
        public String Name { get; set; }
        public String Passwd { get; set; }
        public float Salary { get; set; }
        public float FinalSalary { get; set; }
        public String Limit;        // 权限 ：saleperson,registrar,admin,agent
        public String BankNumber { get; set; }
        public String BankName { get; set; }
        public String TelNumber { get; set; }       //允许NULL
        public String MailNumber { get; set; }      //允许NULL
        public Byte[] Photo { get;set;}             //允许NULL
        public DateTime Birthday { get; set; }
        public String Nation { get; set; }          //名族
        public String Sex { get; set; }             //性别
        public String Address { get; set; }         //联系地址
        public String Department { get; set; }      //部门
        public String Office { get; set; }          //职位
        public String Specialty { get; set; }       //职称
        public String School { get; set; }          //毕业院校
        public DateTime Entrytime { get; set; }     //入职时间
        public String State { get; set; }           //状态：在职，离职，休假
        public String EduBackGround { get; set; }   //教育背景：本科 or　？
        public String Resume { get; set; }          //个人简历
        public String Remark { get; set; }          //备注
        public String HomeTown { get; set; }        //家乡
        public String Major { get; set; }
    }


    public class PERSONLIMIT
    {
        public static string admin = "admin" ;
        public static string saleperson = "saleperson";
        public static string registrar = "registrar";
        public static string agent = "agent";
    }
}
