using System.ComponentModel.DataAnnotations;

namespace WebApplicationMvc.Models
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Range(0.1, 10000, ErrorMessage = "El precio debe estar entre 0.1 - 10000")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock del producto es obligatorio")]
        [Range(1, 500, ErrorMessage = "El stock debe estar entre 1 - 500")]
        public int Stock { get; set; }
    }
}
