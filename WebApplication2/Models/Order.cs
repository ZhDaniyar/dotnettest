namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string NameOfGood { get; set; }
        public string Adress { get; set; }
        //public int CustomerId { get; set; }
        public User User { get; set; }
    }
}
