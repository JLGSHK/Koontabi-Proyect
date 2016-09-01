using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.UnitBL
{
    public interface IUnitBL : IGenericBL<Unit>
    {
        IEnumerable<Sp_GetUnits> Sp_GetUnits();
    }
}
