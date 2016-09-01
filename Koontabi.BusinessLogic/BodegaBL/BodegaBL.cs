using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.BodegaRepository;

namespace Koontabi.BusinessLogic.BodegaBL
{
    public class BodegaBL : IBodegaBL
    {
        private BodegaRepository _repository;

        public BodegaBL()
        {
            _repository = new BodegaRepository();
        }

        public Bodega Add(Bodega entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Bodega Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bodega> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetAllBodega> GetAllBodega()
        {
            return _repository.GetAllBodega();
        }

        public void Update(Bodega entity)
        {
            throw new NotImplementedException();
        }
    }
}
