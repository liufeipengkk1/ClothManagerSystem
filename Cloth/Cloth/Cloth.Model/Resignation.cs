using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    // 辞职信息
    public class Resignation
    {
        public String ID { get; set; }      //离职人ID
        public String Name { get; set; }    //离职人姓名
        public DateTime Time { get; set; }  //离职人时间
        public String Reason { get; set; }  //离职人原因

    }
}
