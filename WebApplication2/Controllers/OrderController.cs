using BusinessLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return Ok(_orderService.GetOrders());
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrdersByUserName(string id)
        {
            return Ok(_orderService.GetOrdersByUserName(id));
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrdersByAdress(string adress)
        {
            return Ok(_orderService.GetOrdersByAdress(adress));
        }
    }
}
