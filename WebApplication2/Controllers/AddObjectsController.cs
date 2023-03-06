using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AddObjectsController : Controller
    {

        private static List<Person> list = new List<Person>();


        [HttpGet]
        public IActionResult GetFiltredItems(Func<Person, bool> p)
        {
            return Ok(list.Where(p));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(list);
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(list[id]);
        }
        [HttpPost]
        public IActionResult AddItem([FromBody] Person person)
        {
            list.Add(person);
            return Ok(list.Count - 1);
        }
        [HttpPost]
        public IActionResult AddItems([FromBody] Person[] persons)
        {

            foreach (Person human in persons)
            {
                list.Add(human);
            }
            return StatusCode(201);
        }
        [HttpPut]
        public IActionResult PutPerson([FromRoute] int id, [FromBody] Person value)
        {
            list[id] = value;
            return StatusCode(201);
        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            list.Remove(list[id]);
            return Ok();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
