using EjsU8_SG_Ej2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjsU8_SG_Ej2.Controllers
{
    public class HomeController : Controller
    {
        //Action de la primera vez que el usuario pide la página
        public IActionResult Index()
        {
            return View();
        }
        //Action cuando el usuario ha pulsado el botón
        [HttpPost]
        public IActionResult Index(string nombre)
        {
            ViewBag.nombre = nombre;
            return View("Saludo");
        }
    }
}