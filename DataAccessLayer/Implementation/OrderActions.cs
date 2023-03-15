using DataAccessLayer.Models;
using DataAccessLayer.Repositories;


namespace DataAccessLayer.Implementation
{
    public class OrderActions : IOrderRepository
    {
        public List<Order> GetOrders()
        {
            using (var context = new UserOrderContext())
            {
                return context.Orders.ToList();
            }     
        }
        public Order GetOrder(int id)
        {
            using (var context = new UserOrderContext())
            {
                var list = context.Orders.ToList();
                return (Order)list.Where(list=> list.Id == id);
            }
        }
        public void AddOrder(Order order) { }
        public void UpdateOrder(Order order) { }
        public void DeleteOrder(int id) { }
    }
}
