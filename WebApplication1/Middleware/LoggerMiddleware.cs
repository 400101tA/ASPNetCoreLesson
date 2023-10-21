namespace WebApplication1.Middleware;

public class LoggerMiddleware
{
    private readonly RequestDelegate _requestDelegate;

    public LoggerMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("this is request");
        await _requestDelegate.Invoke(context);
        Console.WriteLine("This is response");
    }
}