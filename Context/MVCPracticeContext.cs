using Microsoft.EntityFrameworkCore;
using MVC_Practice.Models;

namespace MVC_Practice.Context;

public class ToDoDbContext : DbContext
{
    public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
    {

    }

    public DbSet<ToDo> ToDos { get; set; }
    public DbSet<Student> Students { get; set; }
}
