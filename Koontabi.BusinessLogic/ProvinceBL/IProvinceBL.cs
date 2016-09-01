using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.ProvinceBL
{
    public interface IProvinceBL : IGenericBL<Province>
    {
        IEnumerable<sp_getAllProvinces> GetAllProvinces();
    }
}
