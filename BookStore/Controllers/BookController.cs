using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Repository.IBookRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepos bookRepos;

        public BookController(IBookRepos bookRepos)
        {
            this.bookRepos = bookRepos;
        }
        public IActionResult Index()
        {
            var books = bookRepos.GetBooks();
            if (books == null)
                return NotFound(books);

            return View(books);
        }
        public ViewResult Details(int bookId)
        {
            var book = bookRepos.GetBook(bookId);
            if (book == null)
                

            return View(book);
        }
        public ViewResult Edit()
        {
            return View();
        }
    }
}