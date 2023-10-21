using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data.Entities;

public class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
}