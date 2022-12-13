using Microsoft.AspNetCore.Mvc;
using Week_3_Lab.Models;

namespace Week_3_Lab.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Support(Customer customer)
        {
            var Customer = new Customer();
            return View(customer);
        }
    }
}
