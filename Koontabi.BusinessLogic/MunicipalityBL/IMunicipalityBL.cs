using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.MunicipalityBL
{
    public interface IMunicipalityBL : IGenericBL<Municipality>
    {
        IEnumerable<sp_getAllMunicipalitiesById> GetAllMunicipalitiesById(int id);
    }
}
