using System.Diagnostics;
using CursoProgramacionAvanzadaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoProgramacionAvanzadaWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsuarioController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UsuarioViewModel usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            ViewBag.MensajeExito = "Usuario creado correctamente";
            return View();

        }
    }
}
