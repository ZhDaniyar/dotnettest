using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace BusinessLayer
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

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
    }
}
