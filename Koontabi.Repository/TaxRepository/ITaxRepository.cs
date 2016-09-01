using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.TaxRepository
{
    public interface ITaxRepository : IGenericRepository<Tax>
    {
        IEnumerable<Sp_Taxes> Sp_Taxes();
        Decimal GetTaxValue(int taxID);
    }
}
