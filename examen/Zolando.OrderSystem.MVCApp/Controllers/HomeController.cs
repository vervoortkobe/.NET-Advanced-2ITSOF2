using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Zolando.OrderSystem.DAL.Model;
using Zolando.OrderSystem.MVCApp.Models;

namespace Zolando.OrderSystem.MVCApp.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient SharedClient = new()
        {
            BaseAddress = new("https://localhost:7087")
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        public async Task<IActionResult> Index()
        {
            var list = await SharedClient.GetFromJsonAsync<IEnumerable<Order>>("/api/Orders");
            return View(list);
        }

        /*public async Task<IActionResult> AddNew()
        {
            var storesResult = await SharedClient.GetFromJsonAsync<PagedResult<Store>>("/api/Stores");
            AddNewPersonModel anpm = new()
            {
                Employers = storesResult.Data
            };
            return View(anpm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNew(AddNewPersonModel pm)
        {
            await SharedClient.PostAsJsonAsync<Person>($"/api/People", pm.Person);
            return RedirectToAction("Index");
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //enkel voor test in UI
            //try
            //{
                await SharedClient.DeleteAsync($"/api/Orders/{id}");
                return RedirectToAction("Index");
            //} catch(Exception e)
            //{
            //  return ErrorDeleteViewModel();
            //}
        }
    }
}