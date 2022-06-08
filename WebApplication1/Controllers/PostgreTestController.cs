using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Extensions;
using WebApplication1.Abstract;
using Microsoft.AspNetCore.Authorization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PostgreTestController : PostgreTestControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IJWTManagerRepository _jwtManager;
        public PostgreTestController(IBookService bookService, IJWTManagerRepository jwtManager)
        {
            _bookService = bookService;
            _jwtManager = jwtManager;
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
        [HttpPost]
        public IActionResult Addbook ([FromBody] Book newbook)
        {
            var book = _bookService.GetBookById(newbook.Id);
            if (book==null)
            {
                book = new Book();
                book.Title = newbook.Title;
                book.GenreId = newbook.GenreId;
                book.PublishDate = newbook.PublishDate;
                book.PageCount = newbook.PageCount;
                if (Response.StatusCode == 400)
                    return new BadRequestResult(); 

                _bookService.AddBook(book);
                string url = $"https://{Request.Host}/PostgreTest/{book.Id}";

                return new CreatedResult(url, book);
            }
            return new BadRequestResult();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
            return new OkResult();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _bookService.GetBookById(id);
            if (data == null)
            {
                return NotFound();
            }
            _bookService.DeleteBook(id);
            return new NoContentResult();

        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users usersdata)
        {
            var token = _jwtManager.Authenticate(usersdata);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
