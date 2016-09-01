using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.TaxBL
{
    public interface ITaxBL : IGenericBL<Tax>
    {
        IEnumerable<Sp_Taxes> Sp_Taxes();
        Decimal GetTaxValue(int taxID);
    }
}
