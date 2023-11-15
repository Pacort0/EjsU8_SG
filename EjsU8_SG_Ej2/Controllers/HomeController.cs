using EjsU8_SG_Ej2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjsU8_SG_Ej2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HttpPostIndex(string nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }
    }
}