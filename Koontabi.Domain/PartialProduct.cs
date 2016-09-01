using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public partial class Product
    {
        public static Product CreateNewInstance()
        {
            return new Product();
        }
    }
}
