using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;
using Koontabi.Repository.EmployeeRepository;

namespace Koontabi.BusinessLogic.EmployeeBL
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRepository _repository;
        public EmployeeBL() {
            this._repository = new EmployeeRepository();
        }
        public Employee Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idEntity)
        {
            throw new NotImplementedException();
        }

        public Employee Find(int idEntity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sp_GetEmployeeToComboBox> SpGetEmployeeToComboBox()
        {
            return this._repository.SpGetEmployeeToComboBox();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee ValidateUserAndPass(string userName, string password)
        {
            return this._repository.ValidateUserAndPass(userName, password);
        }
    }
}
