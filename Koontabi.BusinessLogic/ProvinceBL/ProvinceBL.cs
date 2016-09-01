using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.ProvinceRepository;

namespace Koontabi.BusinessLogic.ProvinceBL
{
    public class ProvinceBL : IProvinceBL
    {
        private IProvinceRepository _repository;

        public ProvinceBL()
        {
            _repository = new ProvinceRepository();
        }

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
            return _repository.GetAllProvinces();
        }

        public void Update(Province entity)
        {
            throw new NotImplementedException();
        }
    }
}
