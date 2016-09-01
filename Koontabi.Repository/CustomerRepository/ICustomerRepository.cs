using Koontabi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koontabi.Repository.CustomerRepository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        List<sp_GetAllCustomerRadGridShowData> FillGridView();
        Boolean IsExitCustomerCode(String customerCode);
        Boolean IsExitCustomerDocumentID(String customerDocumentID);
        List<Sp_GetCustomerByParam> GetCustomerByParam(string param);
        List<Sp_GetCustomerByParam> Sp_GetAllCustomerToSearch();
        String GetLastCustomerCode();
    }
}
