namespace WebApplication1.Data.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}