using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using SD_MatrixCrud_MVC.Models;
using System.Diagnostics.Metrics;

var builder = WebApplication.CreateBuilder(args);


// Add services to coneection DataBase do Start<dev>.
//ADICIONAR ANTES DO builder.build()
var connectionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddDbContext<BancoDeDadosContexto>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


