using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace AP.MyGameStore.MVCApp.Controllers
{
    public class StoresController : Controller
    {
        static HttpClient SharedClient = new()
        {
            BaseAddress = new("https://localhost:7087")
        };

        public async Task<IActionResult> Index(int Page = 1)
        {
            var list = await SharedClient.GetFromJsonAsync<PagedResult<Store>>("/api/Stores?pageNumber=" + Page);
            ViewBag.ShowError = TempData["ShowError"];
            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await SharedClient.DeleteAsync($"/api/Stores/{id}");
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                TempData["ShowError"] = true;
            return RedirectToAction("Index");
        }
    }
}
