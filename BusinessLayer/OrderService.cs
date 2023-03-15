using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLayer
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository OrderRepository) 
        {
            _OrderRepository = OrderRepository;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _OrderRepository.GetOrders();
        }
        
        public IEnumerable<Order> GetOrdersByName(string ordername)
        {
            var list = _OrderRepository.GetOrders();
            return list.Where(list=> list.Name == ordername).ToList();
        }
        public IEnumerable<Order> GetOrdersByAdress (string adress)
        {
            var list = _OrderRepository.GetOrders();
            return list.Where(list => list.Adress == adress).ToList();
        }

        public IEnumerable<Order> GetOrders()
        {
            return _orderRepository.GetOrders();
        }

        public IEnumerable<Order> GetOrdersById(int id)
        {
            var list = _orderRepository.GetOrders();
            return list.Where(list => list.Id == id).ToList();
        }
        public IEnumerable<Order> GetOrdersByAdress(string adress)
        {
            var list = _orderRepository.GetOrders();
            return list.Where(list => list.Adress == adress).ToList();
        }

        public IEnumerable<Order> GetOrdersByOrderName(string OrderName)
        {
            var list = _orderRepository.GetOrders();
            return list.Where(list => list.Order.Name == OrderName).ToList();
        }
    }
}
