using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PostgreTestController : PostgreTestControllerBase
    {
        private readonly IBookService _bookService;

        public PostgreTestController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
        [HttpGet("{id}")]
        public Book Details(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
                return null;
            return book;
        }
        [HttpPut]
        public IActionResult Edit([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
            return new OkResult();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id, NotFoundObjectResult notFoundObjectResult)
        {
            var data = _bookService.GetBookById(id);
            if (data == null)
            {
                return notFoundObjectResult;
            }
            _bookService.DeleteBook(id);
            return new OkResult();

        }
    }
}
