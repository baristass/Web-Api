using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class PostgreTestControllerBase
    {
        private readonly IBookService bookService;
    }
}