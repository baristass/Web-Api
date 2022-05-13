using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class PostgreTestControllerBase : ControllerBase
    {
        private readonly IBookService bookService;
    }
}