using DataAccessLayer.Models;
using DataAccessLayer.Repositories;


namespace DataAccessLayer.Implementation
{
    public class UserActions : IUserRepository
    {
        public List<User> GetUsers()
        {
            using (var context = new UserOrderContext())
            {
                return context.Users.ToList();
            }     
        }
        public User GetUser(int id)
        {
            using (var context = new UserOrderContext())
            {
                var list = context.Users.ToList();
                return (User)list.Where(list=> list.Id == id);
            }
        }
        public void AddUser(User user) { }
        public void UpdateUser(User user) { }
        public void DeleteUser(int id) { }
    }
}
