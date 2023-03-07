using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication2.DbContexts
{
    public class UserRepository : IUserRepository
    {
        public UserRepository()
        {
            using (var context = new ApiContext())
            {
                var users = new List<User>()
                {
                    new User
                    {
                        Name = "Kyle",
                        Age = 30,
                        Adress = "New York",
                        Orders = new List<Order>
                        {
                            new Order {NameOfGood = "Ipad", Adress = "New York"},
                            new Order {NameOfGood = "PC", Adress = "New York"},
                            new Order {NameOfGood = "Fifa 23", Adress = "New York"}
                        }
                    },
                    new User
                    {
                        Name = "John",
                        Age = 25,
                        Adress = "LA",
                        Orders = new List<Order>
                        {
                            new Order {NameOfGood = "PS5", Adress = "LA"},
                            new Order {NameOfGood = "XBox", Adress = "LA"},
                            new Order {NameOfGood = "GTA 5", Adress = "LA" }
                        }
                    }
                }; 
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        public List<User> GetUsers()
        {
            using (var context = new ApiContext())
            {
                var list = context.Users.Include(x => x.Orders).ToList();
                return list;
            }
        }
    }
}
