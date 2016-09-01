using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.TaxRepository
{
    public class TaxRepository : ITaxRepository
    {
        public Tax Add(Tax entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Tax Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tax> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_Taxes> Sp_Taxes()
        {
            using (var db = new KoontabiDBEntities()) {
                return db.Sp_Taxes().ToList();
            }
        }

        public void Update(Tax entity)
        {
            throw new NotImplementedException();
        }


        public decimal GetTaxValue(int taxID)
        {
            using (var db = new KoontabiDBEntities()) {
                return (from taxvalue in db.Taxes
                       where taxvalue.TaxID == taxID
                       select taxvalue.TaxValue).SingleOrDefault();
            }
        }
    }
}
