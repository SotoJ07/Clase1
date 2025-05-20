using Clase1.Controllers;
using Clase1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Clase1.Controllers
{
    public class LogInController : Controller
    {
        private readonly ILogger<LogInController> _logger;

        public LogInController(ILogger<LogInController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogInFormulario(LogInViewModel login)
        {
            if (!ModelState.IsValid)
            {
                // Mostrar los errores en la misma vista de login
                return View("Index", login);
            }

            //validaciones de formulario, campos en blanco, formatos, decimal correctos

            // Validaciones capa de negocio, si el usuario y la contrase�a es correcta

            // Validar el nombre de usuario y la contrase�a

            // Autenticaci�n exitosa, redirigir a la p�gina principal
            return RedirectToAction("Index", "Carro");


        }
    }
}