using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DbContexts;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "limitation",
    pattern: "{AddObjects}/{GetById}/{Id}",
    constraints: new { id = new IntRouteConstraint()});
app.MapControllerRoute(
    name: "limitation1",
    pattern: "{controller=AddObjects}/{action=DeleteById}/{{id:int}}");
app.MapControllerRoute(
    name: "limitation2",
    pattern: "{controller=AddObjects}/{action=PutPerson}/{{id:int}}");

app.MapControllerRoute(
                name: "default",
                pattern: "{controller=AddList}/{action=Index}/{id?}");
app.Run();
