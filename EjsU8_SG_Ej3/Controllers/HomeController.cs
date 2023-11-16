using EjsU8_SG_Ej3.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EjsU8_SG_Ej3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Editar()
        {
            clsPersona persona = new clsPersona()
            {
                Id = 1, Nombre = "Francisco", Apellidos="Rodríguez Tejada", Direccion = "Calle Ajetreada", Edad = 20
            };

            return View(persona);  
        }
        [HttpPost]
        public IActionResult Editar(clsPersona persona)
        {
            IActionResult action;
            if (!ModelState.IsValid)
            {
                action = View(persona);
            }
            else
            {
                action = View("PersonaModificada", persona);
            }
            return action;
        }
    }
}