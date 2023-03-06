using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class PersonViewModel
    {
        public IEnumerable<Person> Persons { get; set; } = new List<Person>();
    }
}
