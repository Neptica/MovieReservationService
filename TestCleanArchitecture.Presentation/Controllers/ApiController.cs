using Microsoft.AspNetCore.Mvc;
using TestCleanArchitecture.Application.UseCases;
using Microsoft.AspNetCore.Authorization;

namespace TestCleanArchitecture.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly UserService _userService;
        public ApiController(UserService userService)
        {
            _userService = userService;
        }

        [Route("getall")]
        public IActionResult GetAll()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _userService.GetAll().ToList();
            return Json(test);
        }

        [Route("getallprotected")]
        [Authorize(Policy = "read:epsteinfiles")]
        public IActionResult GetAllProtected()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _userService.GetAll().ToList();
            return Json(test);
        }

        [Route("getallforbidden")]
        [Authorize(Policy = "read:unredactedfiles")]
        public IActionResult GetAllForbidden()
        {
            if (Request.Headers.TryGetValue("Authorization", out var jwtToken)) {
                Console.WriteLine(jwtToken);
            }
            var test = _userService.GetAll().ToList();
            return Json(test);
        }
    }
}
