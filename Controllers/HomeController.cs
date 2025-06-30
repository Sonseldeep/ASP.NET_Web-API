using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBapi.Controllers
{

    public class HomeController : ControllerBase
    {
        [HttpGet("users")]
        public async Task<string> GetUser()
        {
            return await User();
        }

        public async Task<string> User()
        {
            return "Sandeep Shrestha";
        }


    }
}