# Prueba Técnica - Desarrollador C# y .NET (2024)

## 🛠 Tecnologías utilizadas
- ASP.NET (.NET 8)
- Entity Framework Core
- SQL Server (configurado en appsettings.json)
- HTML, CSS y JavaScript (frontend pendiente)
- Arquitectura en capas (Controllers, Models, Data)
- Buenas prácticas SOLID y Clean Code

## 📌 Funcionalidad implementada
- API RESTful con CRUD para la entidad `Producto` y `ImagenProducto`.
- Validaciones de modelos.
- DbContext configurado.
- Migración inicial generada (`InitialCreate`).

## ⚠ Problemas encontrados
Durante el desarrollo se presentó un error persistente al conectar con SQL Server:


Se intentó usar `localdb` y `SQLEXPRESS` sin éxito. Aún así, el desarrollo de la API REST está completo a nivel de lógica, y el DbContext está listo para conectarse una vez resuelto el error.

## 📂 Estructura del proyecto
- `/Controllers` – CRUD de productos e imágenes
- `/Models` – Entidades `Producto` e `ImagenProducto`
- `/Data` – `ProductoDbContext` con configuraciones
- `appsettings.json` – contiene la cadena de conexión
- `Migrations` – migraciones generadas por EF Core

## 🚀 Para ejecutar
1. Clonar el repositorio
2. Revisar la cadena de conexión en `appsettings.json`
3. Ejecutar:
   ```bash
   dotnet ef database update


