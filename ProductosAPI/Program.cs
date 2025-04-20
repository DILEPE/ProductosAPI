using Microsoft.EntityFrameworkCore;
using ProductosAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n del DbContext con la cadena de conexi�n desde appsettings.json
builder.Services.AddDbContext<ProductoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductoDb")));

// Agregar otros servicios como los controladores, etc.
builder.Services.AddControllers();

var app = builder.Build();

// Configuraci�n de la tuber�a de solicitudes HTTP
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
