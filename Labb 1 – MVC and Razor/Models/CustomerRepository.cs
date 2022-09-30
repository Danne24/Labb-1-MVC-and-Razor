using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomer
        {
            get
            {
                return _appDbContext.Customers;
            }
        }



        public void RemoveCustomer(int id)
        {
            Customer customer = _appDbContext.Customers.Find(id);
            _appDbContext.Customers.Remove(customer);
            _appDbContext.SaveChanges();
        }

        public Customer GetCustomerByID(int customerID)
        {
            return _appDbContext.Customers.FirstOrDefault(c => c.CustomerID == customerID);
        }

        public void CreateNewCustomer(Customer customer)
        {
            _appDbContext.Customers.Add(customer);
            _appDbContext.SaveChanges();
        }

        public void EditCustomer(Customer customer)
        {
            _appDbContext.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomerLoans
        {
            get
            {
                return _appDbContext.Customers.Include(c => c.LibraryLoans).ThenInclude(c => c.Book).ToList();
            }
        }
    }
}
