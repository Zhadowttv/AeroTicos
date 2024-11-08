﻿using AeroTicos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AeroTicos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SistemaReserva()
        {
            return View();
        }

        public IActionResult Reserva()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult INFO()
        {
            return View();
        }

        public IActionResult CheckIN()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult PanelAdmin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
