using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public class ProductToSearch
    {
        public int ProductID { get; set; }
        public int ProductDetailID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice1 { get; set; }
        public decimal UnitPrice2 { get; set; }
        public decimal UnitPrice3 { get; set; }
        public int Stock { get; set; }
    }
}
