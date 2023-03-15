using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrder(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
