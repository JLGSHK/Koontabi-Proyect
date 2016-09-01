using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.TypeOfPayRepository
{
    public class TypeOfPayRepository : ITypeOfPayRepository
    {

        public IEnumerable<Sp_TypeOfPay> SpTypeOfPay()
        {
            using (var db = new KoontabiDBEntities()) {
                return db.Sp_TypeOfPay().ToList();
            }

        }

        public TypeOfPayRepository Add(TypeOfPayRepository entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public void Update(TypeOfPayRepository entity)
        {
            throw new NotImplementedException();
        }

        public TypeOfPayRepository Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypeOfPayRepository> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
