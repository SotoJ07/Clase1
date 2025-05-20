using Clase1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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

            // Validaciones capa de negocio, si el usuario y la contrase�a es correcta

            // Validar el nombre de usuario y la contrase�a

            // Autenticaci�n exitosa, redirigir a la p�gina principal
            return RedirectToAction("Privacy", "Home");


        }
    }
}