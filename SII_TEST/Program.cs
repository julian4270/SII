using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using SII_TEST.Controllers;
using SII_TEST.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

List<employee> list = new List<employee>();

app.MapGet("/test", () => "Test!");

app.MapGet("/calculate", () => "");

app.MapGet("/employee", async (TodoDb db) =>
    await db.Todos.ToListAsync());

app.MapGet("/employee/{id}", async (int id, TodoDb db) =>
    await db.Todos.FindAsync(id)
        is employee todo
            ? Results.Ok(todo)
            : Results.NotFound());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
