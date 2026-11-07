namespace WebApplicationMvc.Models
{
    public class CotizacionViewModel
    {
        public string Cliente { get; set; } = string.Empty;
        public decimal PrecioBase { get; set; }
        // Regular, VIP, Corporativo
        public string TipoCliente { get; set; } = "Regular"; 
    }
}
