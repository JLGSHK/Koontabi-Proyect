using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public partial class ProductDetail
    {
        public static ProductDetail CreateNewInstance()
        {
            return new ProductDetail();
        }
    }
}
