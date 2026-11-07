using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class CalculoController : Controller
    {
        [HttpGet]
        public IActionResult DescuentoSucesivo()
        {
            return View(new CotizacionViewModel());
        }

        [HttpPost]
        public IActionResult DescuentoSucesivo(CotizacionViewModel model)
        {
            return View(model);
        }
    }
}
