using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.BodegaBL
{
    public interface IBodegaBL : IGenericBL<Bodega>
    {
        IEnumerable<Sp_GetAllBodega> GetAllBodega();
    }
}
