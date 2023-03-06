using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class AddListController : Controller
    {
        private static List<string> list = new List<string>();
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
        [HttpPut]
        public IActionResult Put([FromRoute]int id, [FromBody]ItemList value) {
            list[id] = value.Id;
            return StatusCode(201);
        }
        
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            list.Remove(list[id]);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddItem([FromBody] ItemList name)
        {
            list.Add(name.Id);
            return Ok(list.Count-1);
        }
        [HttpPost]
        public IActionResult AddItems(string[] names)
        {
            
            foreach (string name in names)
            {
                list.Add(name);
            }
            return StatusCode(201);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
