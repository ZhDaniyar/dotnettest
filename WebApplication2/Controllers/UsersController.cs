using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]  
        public ActionResult<List<User>> Get(string a) 
        {
            if (a == "")
                return new BadRequestObjectResult("asdasd");
            return Ok(_userRepository.GetUsers(a));
        }

        [HttpPost]
        public ActionResult<List<User>> ChangeUsersAbove18()
        {
            return Ok(_userService.ChangeUsersAbove18());
        }
    }
}
