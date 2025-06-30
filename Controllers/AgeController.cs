using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBapi.Controllers
{

    [ApiController]
    public class AgeController : ControllerBase
    {
        [HttpGet("ages")]
        public int GetAge()
        {
            return 21;
        }
    }
}
