using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public class InvoiceDetailGridModel
    {
        public int ProductID { get; set; }
        public int ProductDetailID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get {return UnitPrice* Quantity; } }
    }
}
