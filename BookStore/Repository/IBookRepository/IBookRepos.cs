using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository.IBookRepository
{
    public interface IBookRepos
    {
       Task<Book> GetBook(int bookId);
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> UpdateBook(Book book);
        Task<Book> DeleteBook(int bookId);
        Task<List<Book>> SearchBook(string bookName, string author);
    }
}
