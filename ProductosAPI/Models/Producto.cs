using System;
using System.ComponentModel.DataAnnotations;

namespace ProductosAPI.Models
{
    public class Producto
    {
        // Id del producto
        public int Id { get; set; }

        
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre del producto no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        // Descripción del producto (obligatorio)
        [Required(ErrorMessage = "La descripción del producto es obligatoria.")]
        public string Descripcion { get; set; }

        // Precio del producto (obligatorio, mayor que 0)
        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }

        // Fecha de creación del producto (obligatoria)
        [Required(ErrorMessage = "La fecha de creación es obligatoria.")]
        public DateTime FechaCreacion { get; set; }

        
        [Required(ErrorMessage = "El estado del producto es obligatorio.")]
        public bool Estado { get; set; }
    }
}
