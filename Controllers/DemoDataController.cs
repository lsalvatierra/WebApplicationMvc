using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMvc.Controllers
{
    public class DemoDataController : Controller
    {
        //localhost:8787/DemoData/Procesar

        public IActionResult Procesar()
        {
            //1. Uso del ViewData: [clave/valor]
            ViewData["FechaActual"] = DateTime.Now.ToLongDateString();
            ViewData["CodigoUsuario"] = 457896;
            //2. Uso del ViewBag: maneja objetos dinámicos.
            ViewBag.NombreModulo = "Módulo 2 - Ciclo 2026-33";
            ViewBag.EstadoConexion = true;
            //3. Uso del TempData: Es ideal para redirecciones donde queramos
            //almacenar información temporal.
            TempData["AlertaSeguridad"] = "Acceso temporal concedido por 5 minutos";
            return View();
        }
    }
}
