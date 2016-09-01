using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.TaxRepository;

namespace Koontabi.BusinessLogic.TaxBL
{
    public class TaxBL : ITaxBL
    {
        private ITaxRepository _repository;
        public TaxBL()
        {
            this._repository = new TaxRepository();
        }
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
            return this._repository.Sp_Taxes();
        }

        public void Update(Tax entity)
        {
            throw new NotImplementedException();
        }


        public decimal GetTaxValue(int taxID)
        {
            return this._repository.GetTaxValue(taxID);
        }
    }
}
