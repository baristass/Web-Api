using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.AddControllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private static List<Book> BookList = new List<Book>()
      {
          new Book{

            Id=1,
            Title ="Learn Startup",
            GenreId = 1, // Personel Growth
            PageCount=200,
            PublishDate= new DateTime (2022,05,12)

          },
          new Book{

            Id=2,
            Title ="Herland",
            GenreId = 2, // Science Fiction
            PageCount=250,
            PublishDate= new DateTime (2021,04,11)

          },
          new Book{

            Id=3,
            Title ="Dune",
            GenreId = 1, // Science Fiction
            PageCount=550,
            PublishDate= new DateTime (2020,03,10)

          },
          new Book
          {
              Id=4,
              Title="David Burns",
              GenreId=1, //Personel Growth
              PageCount=400,
              PublishDate= new DateTime (2019,02,09),
          },
      };



        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book => book.Id == id).SingleOrDefault();
            return book ;
        }

        //[HttpGet]
        //public Book Get([FromQuery] string ıd)
        //{
        //    var book = BookList.Where(book => book.Id == Convert.ToInt32(ıd)).SingleOrDefault();
        //    return book;
        // }

        //Post
        [HttpPost]
        public IActionResult Addbook([FromBody] Book newBook)
        {

            var book = BookList.SingleOrDefault(x => x.Title == newBook.Title);
            if (book == null)
            {
                book = new Book();
                book.Id = newBook.Id;
                book.Title = newBook.Title;
                book.GenreId = newBook.GenreId;
                book.PageCount = newBook.PageCount;
                book.PublishDate = DateTime.Now;
                BookList.Add(book);
                return Ok(book);

            }
            return BadRequest();

        }
        //Put
        [HttpPut("{id}")]

        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = BookList.SingleOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();

            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;

            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int ıd)
        {
            var book = BookList.SingleOrDefault(x => x.Id == ıd);
            if (book is null)
                return BadRequest();

            BookList.Remove(book);
            return Ok();


        }

    }
}
