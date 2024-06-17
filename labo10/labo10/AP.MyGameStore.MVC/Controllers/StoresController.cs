using AP.MyGameStore.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AP.MyGameStore.MVC.Controllers
{
    public class StoresController : Controller
    {
        private readonly ILogger<StoresController> _logger;

        public StoresController(ILogger<StoresController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
