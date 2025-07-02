using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBapi.Controllers.Models;

namespace WEBapi.Controllers
{

    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("students")]

        public IEnumerable<StudentData> GetStudents()
        {
            return new List<StudentData>
            {
                new() {
                    Id = 1,
                    Name = "Sandeep Shrestha",
                    College = "Kathmandu University",
                    Age = 21,
                    CollegeName = "School of Engineering"
                },
                new() {
                    Id = 2,
                    Name = "Anita Sharma",
                    College = "Tribhuvan University",
                    Age = 22,
                    CollegeName = "Institute of Science and Technology"
                },
                new() {
                    Id = 3,
                    Name = "Rajesh Kumar",
                    College = "Pokhara University",
                    Age = 23,
                    CollegeName = "School of Business"
                },

            };
        }
    }
}
