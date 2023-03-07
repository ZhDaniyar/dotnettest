using DataAccessLayer.Models;

namespace BusinessLayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}
