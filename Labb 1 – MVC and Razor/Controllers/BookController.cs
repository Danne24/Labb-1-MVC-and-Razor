using Labb_1___MVC_and_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;


        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }


        public IActionResult Index()
        {
            IEnumerable<Book> books;

            books = _bookRepository.GetAllBooks;

            return View(books);
        }
    }
}
