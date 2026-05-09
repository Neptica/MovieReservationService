using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MovieReservationService.Infrastructure.Persistence;

namespace MovieReservationService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ApiController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _dbContext.Users.Take(20).ToList();
            return Json(test);
        }

        [Route("getallprotected")]
        [Authorize(Policy = "read:epsteinfiles")]
        public IActionResult GetAllProtected()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _dbContext.Users.Take(20).ToList();
            return Json(test);
        }

        [Route("getallforbidden")]
        [Authorize(Policy = "read:unredactedfiles")]
        public IActionResult GetAllForbidden()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _dbContext.Users.Take(20).ToList();
            return Json(test);
        }
    }
}
