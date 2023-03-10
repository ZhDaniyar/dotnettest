using DataAccessLayer.Models;

namespace BusinessLayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersByName(string name);
        IEnumerable<User> GetUsersByAdress(string adress);

        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrdersById(int Id);
        IEnumerable<Order> GetOrdersByAdress(string adress);
    }
}
