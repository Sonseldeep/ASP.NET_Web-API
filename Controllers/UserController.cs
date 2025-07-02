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
        public UserData GetUserById(int id)
        {
            return UsersRepository.Users.FirstOrDefault(user => user.Id == id);
        }
    }
}
