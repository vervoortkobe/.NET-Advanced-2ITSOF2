using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Model;
using AP.MyGameStore.MVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AP.MyGameStore.MVCApp.Controllers
{
    public class PeopleController : Controller
    {
        static HttpClient SharedClient = new()
        {
            BaseAddress = new("https://localhost:7087")
        };
        public async Task<IActionResult> Index()
        {
            var list = await SharedClient.GetFromJsonAsync<IEnumerable<Person>>("/api/People");
            return View(list);
        }

        public async Task<IActionResult> AddNew()
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
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await SharedClient.DeleteAsync($"/api/People/{id}");
            return RedirectToAction("Index");
        }
    }
}
