using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Domain.Users;
namespace UMS.Controllers
{
    [Authorize]
    [Route("[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(){}
        [HttpGet("GetUser")]
        public IActionResult GetUser(string id)
        {
            return Problem("Something went wrong");
        }
        
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUser()
        {
            return Problem("Something went wrong");
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(User user)
        {
            return Problem("Something went wrong");
        }
        [HttpPut("EditUser")]
        public IActionResult EditUser(User user)
        {
            return Problem("Something went wrong");
        }
        [HttpPut("DisableUser")]
        public IActionResult DisableUser(string id)
        {
            return Problem("Something went wrong");
        }
    }
}
