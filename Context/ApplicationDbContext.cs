using FirstMicroService.Todos.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMicroService.Todos.WebAPI.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ToDo>  ToDos { get; set; }
}
