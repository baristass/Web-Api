using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.DBOperations;

namespace WebApplication1
{
    public class BookService : IBookService
    {
        private readonly BookStoreDbContext _context;
        public BookService(BookStoreDbContext context)
        {
            _context = context;
        }

       


        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var entity = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(entity);
        }

        public Book GetBookById(int id)
        {
            var book= _context.Books.SingleOrDefault(x => x.Id == id);
            return book;
            return null;





        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            _context.Update(book);
            _context.SaveChanges();
        }
    }
}
