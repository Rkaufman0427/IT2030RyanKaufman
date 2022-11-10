using Microsoft.AspNetCore.Mvc;
using Week_3_Lab.Models;


namespace Week_3_Lab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.TA = 0;
            ViewBag.T = 0;
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





        [HttpPost]
        public IActionResult Index(TaxModel model)
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