using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data;

public sealed class MyDdContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    public MyDdContext(DbContextOptions contextOptionsBuilder) : base(contextOptionsBuilder)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .ToTable("Students1")
            .HasIndex(student => student.Id);
        modelBuilder.Entity<Student>()
            .Property(student => student.Id)
            .ValueGeneratedOnAdd();

        base.OnModelCreating(modelBuilder);
    }
}