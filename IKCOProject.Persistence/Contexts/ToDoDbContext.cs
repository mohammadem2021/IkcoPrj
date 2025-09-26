using System.Reflection;
using IKCOProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IKCOProject.Persistence.Contexts;

public class ToDoDbContext(DbContextOptions<ToDoDbContext> options) : DbContext(options)
{
    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
}