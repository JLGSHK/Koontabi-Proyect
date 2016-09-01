using Koontabi.Repository.MunicipalityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.MunicipalityBL
{
    public class MunicipalityBL : IMunicipalityBL
    {
        private IMunicipalityRepository _repository;

        public MunicipalityBL(){
            _repository = new MunicipalityRepository();
        }

        public IEnumerable<Domain.sp_getAllMunicipalitiesById> GetAllMunicipalitiesById(int id)
        {
            return _repository.GetAllMunicipalitiesById(id);
        }

        public Domain.Municipality Add(Domain.Municipality entity)
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
