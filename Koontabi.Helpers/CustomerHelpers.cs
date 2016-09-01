using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Koontabi.Domain;

namespace Koontabi.Helpers
{
    public static class CustomerHelpers
    {
        /// <summary>
        /// This method will convert to a IEnumerable to a List,
        /// returning a generic type.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns></returns>
        public static IEnumerable<Customer> GetAsListOfCustomer(this IEnumerable<Customer> customers)
        {
            List<Customer> _customers = new List<Customer>();
            foreach (var item in customers)
            {
                _customers.Add(new Customer());
            }
            return _customers;
        }
    }
}
