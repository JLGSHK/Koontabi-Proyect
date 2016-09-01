using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.BodegaRepository
{
    public interface IBodegaRepository : IGenericRepository<Bodega>
    {
        IEnumerable<Sp_GetAllBodega> GetAllBodega();
    }
}
