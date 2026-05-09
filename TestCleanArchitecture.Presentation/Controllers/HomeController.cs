using Microsoft.AspNetCore.Mvc;
using TestCleanArchitecture.Application.UseCases;

namespace TestCleanArchitecture.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _userService;
        public HomeController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            var test = _userService.GetAll().ToList();
            return View();
        }
    }
}
