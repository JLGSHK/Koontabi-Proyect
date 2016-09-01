using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koontabi.Domain
{
    public class ProductInventory
    {
        public String ProductCode { get; set; }
        public String ProductName { get; set; }
        public Decimal ProductCost { get; set; }
        public Decimal UnitPrice1 { get; set; }
        public int Stock { get; set; }
        public Decimal InventoryValue { get; set; }
        public Decimal ValueSale { get; set; }

    }
}
