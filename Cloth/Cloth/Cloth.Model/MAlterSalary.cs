using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{
    public class MAlterSalary
    {
        public String ID { get; set; }
        public String PersonName { get; set; }
        public String Reason { get; set; }
        public float OldSalary { get; set; }
        public float NewSalary { get; set; }
        public DateTime Time { get; set; }
    }
}
