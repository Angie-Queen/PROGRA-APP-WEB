namespace PROGRA_APP_WEB.Models
{
    public class Producto
    {
         [Required]
        [Display(Name="Nombre del producto")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Precio Unitario")]
        public string Precio { get; set; }

        [Required]
        public string Descripcion { get; set; }
    }
}