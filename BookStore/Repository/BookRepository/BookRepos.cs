using BookStore.Context;
using BookStore.Models;
using BookStore.Repository.IBookRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository.BookRepository
{
    public class BookRepos : IBookRepos
    {
        private readonly AppDbContext context;

        public BookRepos(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<Book> DeleteBook(int bookId)
        {
            var book = context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                return null;
             context.Remove(book);
            await context.SaveChangesAsync();
            return book;
        }

        public async Task<Book> GetBook(int bookId)
        {
            var book =  context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                return null;
            return  book;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await context.Books.ToListAsync();
        }

        public async Task<List<Book>> SearchBook(string title, string auther)
        {
            var books = context.Books.Where(b => b.BookTitle.Contains(title) || b.BookAuthor.Contains(auther));
            if (books == null)
                return null;
            return await books.ToListAsync();
        }

        public async Task<Book> UpdateBook(Book book)

        {
            var bk =  context.Books.FirstOrDefaultAsync(b => b.BookId == book.BookId);
            if (bk == null)
                return null;
            Book books = new Book
            {
                BookAuthor = book.BookAuthor,
                BookTitle = book.BookTitle
            };
           await context.SaveChangesAsync();
            return book;
        }

    }
}
