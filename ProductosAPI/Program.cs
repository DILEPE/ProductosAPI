using Microsoft.EntityFrameworkCore;
using ProductosAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuración del DbContext con la cadena de conexión desde appsettings.json
builder.Services.AddDbContext<ProductoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductoDb")));

// Agregar otros servicios como los controladores, etc.
builder.Services.AddControllers();

var app = builder.Build();

// Configuración de la tubería de solicitudes HTTP
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
