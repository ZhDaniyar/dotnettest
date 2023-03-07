namespace DataAccessLayer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string NameOfGood { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public User User { get; set; } = new();
    }
}
