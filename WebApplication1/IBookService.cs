using System.Collections.Generic;

namespace WebApplication1
{
    public interface IBookService
    {
        public void AddBook(Book book);
        public void DeleteBook(int id);
        public Book GetBookById(int id);
        public  List<Book> GetAllBooks();
        public void UpdateBook(Book book);

    }
}