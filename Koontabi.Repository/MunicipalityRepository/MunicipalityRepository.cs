using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.MunicipalityRepository
{
    public class MunicipalityRepository : IMunicipalityRepository
    {
        public IEnumerable<sp_getAllMunicipalitiesById> GetAllMunicipalitiesById(int id)
        {
            using (var db = new KoontabiDBEntities()) 
            {
                return db.sp_getAllMunicipalitiesById(id).ToList();
                
            }
        }

        public Municipality Add(Domain.Municipality entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Municipality entity)
        {
            throw new NotImplementedException();
        }

        public Domain.Municipality Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Municipality> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
