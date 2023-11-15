using EjsU8_SG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjsU8_SG.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saludo()
        {
            return View();
        }
    }
}