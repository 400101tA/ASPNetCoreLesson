namespace WebApplication1.Exceptions;

public class NotFoundException:Exception
{
    public string Message { get; set; }
    public int StatusCode { get; set; }
}