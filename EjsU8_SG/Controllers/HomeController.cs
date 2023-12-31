﻿using Amazon.OpsWorks.Model;
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
        [HttpGet]
        public IActionResult Saludo(string nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }
    }
}