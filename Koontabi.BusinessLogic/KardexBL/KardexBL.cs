using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.KardexRepository;

namespace Koontabi.BusinessLogic.KardexBL
{
    public class KardexBL : IKardexBL
    {
        private IKardexRepository _repository;
        public KardexBL()
        {
            this._repository = new KardexRepository();
        }

        public int AddKardex(Kardex _k)
        {
            return this._repository.AddKardex(_k);
        }

        public IEnumerable<KardexGridModel> GetAllKardexGridModel(string productCode,int bodegaID)
        {
            return this._repository.GetAllKardexGridModel(productCode,bodegaID);
        }
    }
}
