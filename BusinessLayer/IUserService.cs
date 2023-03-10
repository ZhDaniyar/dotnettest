using DataAccessLayer.Models;

namespace BusinessLayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByName(string name);
    }
}
