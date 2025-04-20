using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductosAPI.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede ser mayor a 100 caracteres.")]
        public string Nombre { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede ser mayor a 500 caracteres.")]
        public string Descripcion { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Estado { get; set; }

        // Relación uno a muchos: un producto puede tener muchas imágenes
        public ICollection<ImagenProducto> Imagenes { get; set; }
    }
}
