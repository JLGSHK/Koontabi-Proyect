using System;
using System.Collections.Generic;
using System.Linq;
using Koontabi.Domain;
namespace Koontabi.Repository.BodegaRepository
{
    public class BodegaRepository : IBodegaRepository
    {
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
            using (var db = new KoontabiDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Sp_GetAllBodega().ToList();
            }
        }

        public void Update(Bodega entity)
        {
            throw new NotImplementedException();
        }
    }
}
