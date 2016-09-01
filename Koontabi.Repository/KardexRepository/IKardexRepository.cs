using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.KardexRepository
{
    public interface IKardexRepository
    {
        IEnumerable<KardexGridModel> GetAllKardexGridModel(string productCode,int bodegaID);
        Int32 AddKardex(Kardex _k);
    }
}
