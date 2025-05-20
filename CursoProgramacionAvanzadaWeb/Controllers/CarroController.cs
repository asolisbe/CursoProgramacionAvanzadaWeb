using System.Diagnostics;
using CursoProgramacionAvanzadaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoProgramacionAvanzadaWeb.Controllers
{
    public class CarroController : Controller
    {
        private readonly ILogger<CarroController> _logger;

        public CarroController(ILogger<CarroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CarroFormulario(CarroViewModel carro)
        {
            if (!ModelState.IsValid)
            {
                // Mostrar los errores en la misma vista de login
                return View("Index", carro);
            }

            //validaciones de formulario, campos en blanco, formatos, decimal correctos

            // Validaciones capa de negocio, si el usuario y la contraseña es correcta

            // Validar el nombre de usuario y la contraseña

            // Autenticación exitosa, redirigir a la página principal
            return RedirectToAction("Privacy", "Home");


        }
    }
}
