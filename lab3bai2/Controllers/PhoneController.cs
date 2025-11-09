using lab3bai2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3bai2.Controllers
{
    public class PhoneController : Controller
    {
        private readonly TestPhone _repo = new TestPhone();

        public IActionResult Index()
        {
            var list = _repo.GetAll();
            return View(list); // Views/Phone/Index.cshtml
        }

        public IActionResult Details(int id)
        {
            var item = _repo.GetById(id);
            if (item == null) return NotFound();
            return View(item); // tìm Views/Phone/Details.cshtml
        }

    }
}
