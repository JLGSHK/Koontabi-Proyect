using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.ProvinceRepository
{
    public interface IProvinceRepository : IGenericRepository<Province>
    {
        IEnumerable<sp_getAllProvinces> GetAllProvinces();
    }
}
