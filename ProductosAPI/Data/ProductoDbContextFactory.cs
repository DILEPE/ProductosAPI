using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProductosAPI.Data;

namespace ProductosAPI.Data
{
    public class ProductoDbContextFactory : IDesignTimeDbContextFactory<ProductoDbContext>
    {
        public ProductoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductoDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=ProductosDb;Trusted_Connection=True;");

            return new ProductoDbContext(optionsBuilder.Options);
        }
    }
}
