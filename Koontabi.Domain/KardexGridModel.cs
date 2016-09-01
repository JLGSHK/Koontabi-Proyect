using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public class KardexGridModel
    {
        public DateTime RegisterDate { get; set; }
        public string ProductCode { get; set; }
        public String ProductName { get; set; }
        public String TypeOfMove { get; set; }
        public Nullable<Int32> KardexIn { get; set; }
        public Nullable<Int32> KardexOut { get; set; }
        public Nullable<Int32> KardexStock { get; set; }
        
    }
}
