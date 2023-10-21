namespace ConsoleApp1;

public class Student
{
    public  int Grade { get; set; }
    

    public string GetName(string name)
    {
        name = "12312";
        return name;
    }
    

    public string Name { get; set; }
    
    public void Dispose()
    {
        Grade = 345;
        Console.WriteLine("horij rost hizmat ba");
    }
}