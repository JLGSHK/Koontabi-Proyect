using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.UnitRepository
{
    public interface IUnitRepository : IGenericRepository<Unit>
    {
        IEnumerable<Sp_GetUnits> Sp_GetUnits();
    }
}
