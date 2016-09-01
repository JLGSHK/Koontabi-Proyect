using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.TypeOfPayBL
{
    public interface ITypeOfPayBL : IGenericBL<TypeOfPay>
    {
        IEnumerable<Sp_TypeOfPay> SpTypeOfPay();
    }
}
