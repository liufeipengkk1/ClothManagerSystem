using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    //请假信息
    public class AskForLeave
    {
        public String ID { get; set; }      //请假人人ID
        public String Name { get; set; }    //请假人姓名
        public int Days { get; set; }       //请假天数
        public DateTime Time { get; set; }  //请假人时间
        public String Reason { get; set; }  //请假人原因
    }
}
