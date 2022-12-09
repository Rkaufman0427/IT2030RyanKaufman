using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Week_3_Lab.Models;


namespace Week_3_Lab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tools()
        {
            HttpContext.Session.SetString("Course", "IT2030");
            HttpContext.Session.SetString("StudentID", "S00611956");
            HttpContext.Session.SetInt32("CurrentDate", 20221209);

            ViewBag.TA = 0;
            ViewBag.T = 0;
            return View();
        }


        [HttpPost]
        public IActionResult TOOLS(TaxModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.TA = model.CalculateTaxAmount();
                ViewBag.T = model.CalculateTotal();
            }
            else
            {
                ViewBag.TA = 0;
                ViewBag.T = 0;
            }
            return View(model);
        }
    }
}