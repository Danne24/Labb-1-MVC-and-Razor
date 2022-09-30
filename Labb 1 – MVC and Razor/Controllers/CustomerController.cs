using Labb_1___MVC_and_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;
        private IBookRepository _bookRepository;

        public CustomerController(ICustomerRepository customerRepository, IBookRepository bookRepository)
        {
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Customer> customers;

            customers = _customerRepository.GetAllCustomer;

            return View(customers);
        }

                

        [HttpPost, ActionName("Delete")]
        public IActionResult Remove(int id)
        {
            Customer customer = _customerRepository.GetCustomerByID(id);
            _customerRepository.RemoveCustomer(id);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details(int id)
        {
            IEnumerable<Customer> customers;
          
            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerID == id);
            return View(customers);
        }

        public IActionResult ActiveLoans(int id)
        {
            IEnumerable<Customer> customers;

          
            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerID == id);
            return View(customers);
        }

        public IActionResult LoanHistory(int id)
        {
            IEnumerable<Customer> customers;

          
            customers = _customerRepository.GetCustomerLoans.Where(c => c.CustomerID == id);
            return View(customers);
        }

        public IActionResult AddOrEditCustomer(int id)
        {
            if (id == 0)
            {
                return View(new Customer());
            }
            else
            {
                return View(_customerRepository.GetCustomerByID(id));
            }
        }

        [HttpPost]
        public IActionResult AddOrEditCustomer([Bind("CustomerID, CustomerFirstName, CustomerLastName, CustomerAge, CustomerGender")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerID == 0)
                {
                    _customerRepository.CreateNewCustomer(customer);
                }
                else
                {
                    _customerRepository.EditCustomer(customer);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(customer);
        }
    }
}
