using Microsoft.EntityFrameworkCore;
using ProductosAPI.Models;

namespace ProductosAPI.Data
{
    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext(DbContextOptions<ProductoDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<ImagenProducto> Imagenes { get; set; }

        // Configuraci�n adicional para el modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la propiedad 'Precio' con la precisi�n y escala necesarias
            modelBuilder.Entity<Producto>()
                .Property(p => p.Precio)
                .HasColumnType("decimal(18,2)");  // Definir precisi�n de 18 y escala de 2 decimales
        }
    }
}
