using DataAccessLayer.Models;

namespace BusinessLayer
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrdersById(int Id);
        IEnumerable<Order> GetOrdersByUserName(string userName);
        IEnumerable<Order> GetOrdersByAdress(string adress);
    }
}
