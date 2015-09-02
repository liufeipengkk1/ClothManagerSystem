using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    //迟到信息
    public class BeLate
    {
        public String ID { get; set; }      //迟到人ID
        public String Name { get; set; }    //迟到人姓名
        public DateTime Time { get; set; }  //迟到人时间
        public String Reason { get; set; }  //迟到人原因
    }
}
