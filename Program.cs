using FirstMicroService.Todos.WebAPI.Context;
using FirstMicroService.Todos.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseInMemoryDatabase("MyDb");
});

var app = builder.Build();

app.MapGet("/todos/create", (string work,ApplicationDbContext context) =>
{
    ToDo toDo = new ToDo() 
    { 
        Work = work
    };
       
    context.Add(toDo);
    context.SaveChanges();

    return new { Message = "Todo create is succesful" };
});

app.MapGet("/todos/getall", (ApplicationDbContext context) =>
{
    var todos = context.ToDos.ToList();
    return todos;
});

app.Run();
