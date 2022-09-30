using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer { get; }
        IEnumerable<Customer> GetCustomerLoans { get; }
        Customer GetCustomerByID(int customerID);
        void EditCustomer(Customer customer);
        void RemoveCustomer(int id);
        void CreateNewCustomer(Customer customer);
    }
}
