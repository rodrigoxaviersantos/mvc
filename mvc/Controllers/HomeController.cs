using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System.Diagnostics;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View("Sobre");
        }

        public IActionResult Contato()
        {

            return View("Contato");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
