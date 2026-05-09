using Microsoft.AspNetCore.Mvc;
using MovieReservationService.Infrastructure;
using MovieReservationService.Infrastructure.Persistence;

namespace MovieReservationService.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
