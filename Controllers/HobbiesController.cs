using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBapi.Controllers
{
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        [HttpGet("hobbies")]

        public List<string> GetHobbies()
        {
            return MyHobbies;
        }

        public List<string> MyHobbies = new()
        {
            "Reading",
            "Traveling",
            "Cooking",
            "Gardening",
            "Photography"
        };
    }
}
