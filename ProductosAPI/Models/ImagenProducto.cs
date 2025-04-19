using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductosAPI.Models
{
    public class ImagenProducto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "La URL no puede ser mayor a 500 caracteres.")]
        public string Url { get; set; }

        [Required]
        public int ProductoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Estado { get; set; }

        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }
    }
}
