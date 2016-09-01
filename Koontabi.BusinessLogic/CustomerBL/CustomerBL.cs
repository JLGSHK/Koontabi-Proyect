using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository;
using Koontabi.Repository.CustomerRepository;

namespace Koontabi.BusinessLogic.CustomerBL
{
    public class CustomerBL : ICustomerBL
    {
        private ICustomerRepository _repository;
        public CustomerBL()
        {
            _repository = new CustomerRepository();
        }
        public Customer Add(Customer entity)
        {
           return _repository.Add(entity);
        }

        public void Delete(int idEntity)
        {
            _repository.Delete(idEntity);

        }

        public List<sp_GetAllCustomerRadGridShowData> FillGridView()
        {
            return _repository.FillGridView();
        }

        public Customer Find(int idEntity)
        {
            return _repository.Find(idEntity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this._repository.GetAll();
        }

        public void Update(Customer entity)
        {
            _repository.Update(entity);
        }


        public bool IsExitCustomerCode(string customerCode)
        {
            return _repository.IsExitCustomerCode(customerCode);
        }


        public List<Sp_GetCustomerByParam> GetCustomerByParam(string param)
        {
            return _repository.GetCustomerByParam(param);
        }


        public List<Sp_GetCustomerByParam> Sp_GetAllCustomerToSearch()
        {
            return _repository.Sp_GetAllCustomerToSearch();
        }

        public string GetLastCustomerCode()
        {
            return this._repository.GetLastCustomerCode();
        }

        public bool IsExitCustomerDocumentID(string customerDocumentID)
        {
            return this._repository.IsExitCustomerDocumentID(customerDocumentID);
        }
    }
}
