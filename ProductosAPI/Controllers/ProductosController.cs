using Microsoft.AspNetCore.Mvc;
using ProductosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        // Lista estática para simular la base de datos
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Protf", Descripcion = "Proteina", Precio = 100, FechaCreacion = DateTime.Now, Estado = true },
            new Producto { Id = 2, Nombre = "Transfer factor plus", Descripcion = "suplemento", Precio = 200, FechaCreacion = DateTime.Now, Estado = true }
        };

        // GET api/productos
        [HttpGet]
        public IActionResult GetProductos()
        {
            return Ok(productos);
        }

        // GET api/productos/1
        [HttpGet("{id}")]
        public IActionResult GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        // POST api/productos
        [HttpPost]
        public IActionResult CreateProducto([FromBody] Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            producto.Id = productos.Count + 1; 
            producto.FechaCreacion = DateTime.Now; 
            productos.Add(producto);

            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }

        // PUT api/productos/1
        [HttpPut("{id}")]
        public IActionResult UpdateProducto(int id, [FromBody] Producto producto)
        {
            var existingProducto = productos.FirstOrDefault(p => p.Id == id);
            if (existingProducto == null)
            {
                return NotFound();
            }

            existingProducto.Nombre = producto.Nombre;
            existingProducto.Descripcion = producto.Descripcion;
            existingProducto.Precio = producto.Precio;
            existingProducto.FechaCreacion = producto.FechaCreacion;
            existingProducto.Estado = producto.Estado;

            return NoContent();
        }

        // DELETE api/productos/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            productos.Remove(producto);

            return NoContent();
        }
    }
}
