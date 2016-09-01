using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.MunicipalityRepository
{
    public interface IMunicipalityRepository : IGenericRepository<Municipality>
    {
        IEnumerable<sp_getAllMunicipalitiesById> GetAllMunicipalitiesById(int id);

    }
}
