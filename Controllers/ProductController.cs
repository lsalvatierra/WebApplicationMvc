using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    [Route("almacen")]
    public class ProductController : Controller
    {
        //Por defecto .Net nos define la URL =
        //localhost:8080/Product/Index

        //ROUTE => modificando la URL =
        //localhost:8080/almacen/nuevo-producto
        [HttpGet]
        [Route("nuevo-producto")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [Route("nuevo-producto")]
        public IActionResult Registro(ProductViewModel model)
        {
            //Siempre en cuando no se cumpla con la validación
            //defininida en el ProductViewModel
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            TempData["MensajeExito"] = $"Producto: '{model.Nombre}' " +
                $" registrado correctamente";
            return RedirectToAction(nameof(Registro));
        }
    }
}
