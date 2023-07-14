using AccesoDatos.Models;
using AccesoDatos.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AplicacionesContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UsuarioConexion"));
});

builder.Services.AddScoped<IRepositorioAplicacion, RepositorioAplicacion>();
builder.Services.AddScoped<IRepositorioDapper, RepositorioDapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
