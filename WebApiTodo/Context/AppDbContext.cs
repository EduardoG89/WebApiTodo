using Microsoft.EntityFrameworkCore;
using WebApiTodo.Models;

namespace WebApiTodo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<TaskModel> Tareas { get; set; }
    }
}
