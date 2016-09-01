using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoonException
{
    [Serializable]
    public class PaidAccountsNotFoundException : Exception
    {

        public PaidAccountsNotFoundException() : base() { }
        public PaidAccountsNotFoundException(String msg) : base(msg) { }

    }
}
