using Microsoft.AspNetCore.Mvc;

namespace MyGameStore.API.Controllers
{
    public class StoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
