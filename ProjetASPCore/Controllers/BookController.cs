using Microsoft.AspNetCore.Mvc;
using ProjetASPCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var bookListViewModel = new BookListViewModel();
            bookListViewModel.Books = _bookRepository.GetAllBooks();
            return View(bookListViewModel);
        }

        public IActionResult Details(int idBook)
        {
            var book = _bookRepository.GetBookById(idBook);
            if (book == null)
                return NotFound();
            else
                return View(book);
        }
    }
}
