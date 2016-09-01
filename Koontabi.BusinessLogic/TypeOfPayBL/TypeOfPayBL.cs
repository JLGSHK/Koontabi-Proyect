using Koontabi.Domain;
using Koontabi.Repository.TypeOfPayRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.BusinessLogic.TypeOfPayBL
{
    public class TypeOfPayBL : ITypeOfPayBL
    {
        private ITypeOfPayRepository _repositoy = null;

        public TypeOfPayBL() {
            this._repositoy = new TypeOfPayRepository();
        }
        public IEnumerable<Sp_TypeOfPay> SpTypeOfPay()
        {
            return this._repositoy.SpTypeOfPay();
        }

        public Domain.TypeOfPay Add(Domain.TypeOfPay entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.TypeOfPay entity)
        {
            throw new NotImplementedException();
        }

        public Domain.TypeOfPay Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.TypeOfPay> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
