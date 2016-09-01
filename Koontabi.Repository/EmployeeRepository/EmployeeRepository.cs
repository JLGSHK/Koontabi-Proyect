using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Repository.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
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
            using(var db = new KoontabiDBEntities())
            {
                return db.Sp_GetEmployeeToComboBox().ToList();
            }
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee ValidateUserAndPass(string userName, string password)
        {
            using(var db = new KoontabiDBEntities())
            {
                var result = (from emp in db.Employees
                             where emp.EmpUserName == userName
                             where emp.EmpPassword == password
                             select emp).FirstOrDefault();
                return result != null? result : null;
            }
        }
    }
}
