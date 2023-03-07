using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetUsers();
        Order GetUser(int id);
        void AddUser(Order user);
        void UpdateUser(Order user);
        void DeleteUser(int id);
    }
}
