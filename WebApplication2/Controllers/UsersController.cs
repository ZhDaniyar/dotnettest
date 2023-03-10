using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

namespace WebApplication2.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_userService.GetUsers());
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsersByName(string id)
        {
            return Ok(_userService.GetUsersByName(id));
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsersByAdress(string adress)
        {
            return Ok(_userService.GetUsersByAdress(adress));
        }
    }
}
