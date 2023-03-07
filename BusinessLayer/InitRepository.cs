using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public static class UserOrderDbHelper
    {
        public static void InitRepository()
        {
            using (var context = new UserOrderContext())
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
        
    }
}
