using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.ProvinceRepository
{
    public class ProvinceRepository : IProvinceRepository
    {
        public Province Add(Province entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Province Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Province> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<sp_getAllProvinces> GetAllProvinces()
        {
            using(var db = new KoontabiDBEntities())
            {
                return db.sp_getAllProvinces().ToList();
            }
        }

        public void Update(Province entity)
        {
            throw new NotImplementedException();
        }
    }
}
