using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.TypeOfPayRepository
{
    public interface ITypeOfPayRepository : IGenericRepository<TypeOfPayRepository>
    {
        IEnumerable<Sp_TypeOfPay> SpTypeOfPay();
    }
}
