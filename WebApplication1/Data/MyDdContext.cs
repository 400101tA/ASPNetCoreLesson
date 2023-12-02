using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data;

public sealed class MyDdContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    public DbSet<Book> Books { get; set; }

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

        modelBuilder.Entity<Student>()
            .HasMany<Book>(student => student.Books)
            .WithOne(book => book.Student)
            .HasForeignKey(book => book.StudentId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        base.OnModelCreating(modelBuilder);
    }
}