using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Domain
{
    public partial class Municipality
    {
        public static Municipality CreateNewInstance()
        {
            return new Municipality();
        }
    }
}