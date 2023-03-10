using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.Implementation
{
    internal class UserActions : IUserRepository
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
                return list[id];
            }
        }
        public void AddUser(User user) { }
        public void UpdateUser(User user) { }
        public void DeleteUser(int id) { }
    }
}
