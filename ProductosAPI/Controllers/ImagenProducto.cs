using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductosAPI.Models;

namespace ProductosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenesProductosController : ControllerBase
    {
        // Lista estática para simular la base de datos
        private static List<ImagenProducto> imagenesProductos = new List<ImagenProducto>
        {
            new ImagenProducto { Id = 1, ProductoId = 1, Url = "imagen1.jpg", FechaCreacion = DateTime.Now, Estado = true },
            new ImagenProducto { Id = 2, ProductoId = 2, Url = "imagen2.jpg", FechaCreacion = DateTime.Now, Estado = true }
        };

        // GET api/imagenesproductos
        [HttpGet]
        public IActionResult GetImagenesProductos()
        {
            return Ok(imagenesProductos);
        }

        // GET api/imagenesproductos/1
        [HttpGet("{id}")]
        public IActionResult GetImagenProducto(int id)
        {
            var imagen = imagenesProductos.FirstOrDefault(i => i.Id == id);
            if (imagen == null)
            {
                return NotFound();
            }
            return Ok(imagen);
        }

        // POST api/imagenesproductos
        [HttpPost]
        public IActionResult CreateImagenProducto([FromBody] ImagenProducto imagenProducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            imagenProducto.Id = imagenesProductos.Count + 1; // Asigna un nuevo Id
            imagenProducto.FechaCreacion = DateTime.Now; // Asigna la fecha de creación
            imagenesProductos.Add(imagenProducto);

            return CreatedAtAction(nameof(GetImagenProducto), new { id = imagenProducto.Id }, imagenProducto);
        }

        // PUT api/imagenesproductos/1
        [HttpPut("{id}")]
        public IActionResult UpdateImagenProducto(int id, [FromBody] ImagenProducto imagenProducto)
        {
            var imagen = imagenesProductos.FirstOrDefault(i => i.Id == id);
            if (imagen == null)
            {
                return NotFound();
            }

            imagen.Url = imagenProducto.Url;
            imagen.Estado = imagenProducto.Estado;
            imagen.ProductoId = imagenProducto.ProductoId;
            imagen.FechaCreacion = imagenProducto.FechaCreacion;

            return NoContent(); // Confirma que la actualización fue exitosa
        }

        // DELETE api/imagenesproductos/1
        [HttpDelete("{id}")]
        public IActionResult DeleteImagenProducto(int id)
        {
            var imagen = imagenesProductos.FirstOrDefault(i => i.Id == id);
            if (imagen == null)
            {
                return NotFound();
            }

            imagenesProductos.Remove(imagen);

            return NoContent(); // Elimina la imagen
        }
    }
}