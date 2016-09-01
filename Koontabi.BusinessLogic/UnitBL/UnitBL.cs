using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.UnitRepository;

namespace Koontabi.BusinessLogic.UnitBL
{
    public class UnitBL : IUnitBL
    {
        private IUnitRepository _repository;
        public UnitBL()
        {
            this._repository = new UnitRepository();
        }
        public Unit Add(Unit entity)
        {
            return this._repository.Add(entity);
        }

        public void Delete(int idEntity)
        {
            this._repository.Delete(idEntity);
        }

        public Unit Find(int idEntity)
        {
            return this._repository.Find(idEntity);
        }

        public IEnumerable<Unit> GetAll()
        {
            return this._repository.GetAll();
        }

        public IEnumerable<Sp_GetUnits> Sp_GetUnits()
        {
            return this._repository.Sp_GetUnits();
        }

        public void Update(Unit entity)
        {
            this._repository.Update(entity);
        }
    }
}
