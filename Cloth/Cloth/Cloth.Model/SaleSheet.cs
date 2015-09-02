using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    //销售清单
    public class SaleSheet
    {
        public String SalePersonID { get; set; }
        public String ClothID { get; set; }
        public DateTime SaleTime { get; set; }
        public float Ticheng { get; set; }
    }
}
