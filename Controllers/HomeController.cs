using Jardin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jardin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Jardins J = new Jardins();
            J.Name = "Poudlard";
            _context.jardins.Add(J);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}