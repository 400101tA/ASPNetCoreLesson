namespace WebApplication1.Middleware;

public static class LoggerMiddlewareExtension
{
    public static void UseLogger(this IApplicationBuilder builder,string? yagonchiz)
    {
        builder.UseMiddleware<LoggerMiddleware>();
    }
    
}