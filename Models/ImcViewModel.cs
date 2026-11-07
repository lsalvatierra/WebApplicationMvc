using System.ComponentModel.DataAnnotations;

namespace WebApplicationMvc.Models
{
    public class ImcViewModel
    {
        [Required(ErrorMessage = "El nombre del paciente es obligatorio")]
        [StringLength(50, 
            ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        [Display(Name = "Nombre del Paciente")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El peso del paciente es obligatorio")]
        [Display(Name = "Peso del Paciente")]
        [Range(10.0, 300.0, ErrorMessage = "El peso debe estar entre 10 y 300 kg")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "La talla del paciente es obligatorio")]
        [Display(Name = "Talla del Paciente")]
        [Range(0.5, 2.5, ErrorMessage = "El peso debe estar entre 0.5 y 2.5 mts.")]
        public double Talla { get; set; }


        //Atributos de salida:
        public double ResultadoImc {  get; set; }
        public string Diagnostico { get; set; } = string.Empty;
        public string ClaseCss { get; set; } = string.Empty;
    }
}
