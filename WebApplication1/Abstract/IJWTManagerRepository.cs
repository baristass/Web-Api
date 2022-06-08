using WebApplication1.Models;

namespace WebApplication1.Abstract
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
