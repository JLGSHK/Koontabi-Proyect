using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Add(T entity);
        void Delete(Int32 idEntity);
        void Update(T entity);
        T Find(Int32 idEntity);
        IEnumerable<T> GetAll();
        
    }
}
