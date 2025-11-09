using Microsoft.AspNetCore.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class CustomerController : Controller
    {
        private readonly TestCustomer _testCustomer = new TestCustomer();

        public IActionResult Index()
        {
            var list = _testCustomer.GetAll();
            return View("~/Views/Home/Index.cshtml", list); // 🔥 chỉ rõ đường dẫn view
        }

        public IActionResult Details(int id)
        {
            var item = _testCustomer.GetById(id);
            if (item == null) return NotFound();
            return View("~/Views/Home/Details.cshtml", item); // 🔥 chỉ rõ đường dẫn view
        }

    }
}
