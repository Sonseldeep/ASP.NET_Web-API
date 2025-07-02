using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBapi.Controllers.Models;

namespace WEBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("users")]
        public IEnumerable<UserData> GetUserDetails()
        {
            return UsersRepository.Users;
        }

        [HttpGet("{id:int}")]
        public ActionResult<UserData> GetUserById(int id)
        {
            var user = UsersRepository.Users.FirstOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }
            return user;
        }
    }
}
