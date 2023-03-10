using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IOrderRepository _orderRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }
        
        public IEnumerable<User> GetUsersByName(string username)
        {
            var list = _userRepository.GetUsers();
            return list.Where(list=> list.Name == username).ToList();
        }
        public IEnumerable<User> GetUsersByAdress (string adress)
        {
            var list = _userRepository.GetUsers();
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
    }
}
