using Microsoft.AspNetCore.Mvc;

namespace MyGameStore.Controllers
{
    public class StoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
