using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothModel
{

    //衣服信息
    public class Cloth
    {
        //最重要信息 不允许为NULL
        public String ID { get; set; }          //条码
        public String Style { get; set; }       //款号
        public String Name { get; set; }        //产品姓名
        public String Color { get; set; }       //色号
        public String Size { get; set; }        //尺寸
        public float Price { get; set; }         //进货价格
        public float SalePrice { get; set; }     //售价
        public float Profit { get; set; }        //利润
        public String SaleState { get; set; }   //销售状态：在售，下架，已售

        //次要信息 以下允许为NULL值
        public byte[] Logo { get; set; }        //imge:logo
        public String Standard { get; set; }    // 标准
        public String CheckCode { get; set; }       //检验码
        public String ClothLevel { get; set; }           //等级
        public String ManufacturerInfo { get; set; }//生产信息
        public DateTime ImportTime { get; set; }    //进货时间
    }

    public static class SALESTATE
    {
        public static String onsale = "onsale";
        public static String sold = "sold";
        public static String offshalves = "offshalves";
        public static String warehouse = "warehouse";
    }
}
