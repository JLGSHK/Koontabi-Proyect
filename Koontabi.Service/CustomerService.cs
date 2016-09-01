using Koontabi.BusinessLogic;
using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Service
{
    public class CustomerService : IService<Customer>
    {
        private IBLGeneric<Customer> _iBLGeneric;
        public CustomerService()
        {
            _iBLGeneric = new CustomerBL();
        }
        public void Add(Customer entity)
        {
            _iBLGeneric.Add(entity);
        }

        public void Delete(int idEntity)
        {
            _iBLGeneric.Delete(idEntity);
        }

        public Object FillGridView()
        {
            return _iBLGeneric.FillGridView();
        }

        public Customer Find(int idEntity)
        {
            return _iBLGeneric.Find(idEntity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _iBLGeneric.GetAll();
        }

        public void Update(Customer entity)
        {
            _iBLGeneric.Update(entity);
        }
    }
}
