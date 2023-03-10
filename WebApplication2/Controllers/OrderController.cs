using BusinessLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUserService _userService;

        public OrderController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return Ok(_userService.GetOrders());
        }
        [HttpGet]
        public ActionResult<List<Order>> GetOrdersById(int id)
        {
            return Ok(_userService.GetOrdersById(id));
        }
        [HttpGet]
        public ActionResult<List<Order>> GetOrdersByAdress(string adress)
        {
            return Ok(_userService.GetOrdersByAdress(adress));
        }
    }
}
