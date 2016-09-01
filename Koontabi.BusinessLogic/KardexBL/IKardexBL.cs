using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.KardexBL
{
    public interface IKardexBL
    {
        IEnumerable<KardexGridModel> GetAllKardexGridModel(string productCode, int bodegaID);
        Int32 AddKardex(Kardex _k);
    }
}
