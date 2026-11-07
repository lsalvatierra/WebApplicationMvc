using Microsoft.AspNetCore.Mvc;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    //[Route("salud")]
    public class ImcController : Controller
    {
        [HttpGet]
        //[Route("evaluar-imc")]
        public IActionResult Calcular()
        {
            return View(new ImcViewModel());
        }

        [HttpPost]
        //[Route("evaluar-imc")]
        public IActionResult Calcular(ImcViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            model.ResultadoImc = model.Peso / (model.Talla * model.Talla);
            if(model.ResultadoImc < 18.5) {
                model.Diagnostico = "Bajo de Peso";
                model.ClaseCss = "alert-warning";
            } else if (model.ResultadoImc < 25) {
                model.Diagnostico = "Peso Normal (Saludable)";
                model.ClaseCss = "alert-success";
            } else if (model.ResultadoImc < 30) {
                model.Diagnostico = "Sobrepeso";
                model.ClaseCss = "alert-info";
            } else {
                model.Diagnostico = "Obesidad";
                model.ClaseCss = "alert-danger";
            }
            ViewData["Procesado"] = true;
            return View(model);
        }
            
    }
}
