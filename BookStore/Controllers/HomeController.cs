using BookStore.Models;
using BookStore.Repository.BookRepository;
using BookStore.Repository.IBookRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "Hellow from index action of home controller";
        }
    }
}
