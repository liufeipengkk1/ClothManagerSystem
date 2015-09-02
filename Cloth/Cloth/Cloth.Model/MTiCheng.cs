using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    public class MTiCheng
    {
        public String Name { get; set; }        //提成方案姓名
        public WAY Ways { get; set; }
        public float Up { get; set; }             //提成方案上限
        public float Down { get; set; }        //提成方案下限
        public float Money { get; set; }        //提成钱数
    }

    public enum WAY {PERCENTAGE = 0,MONEY};
}
