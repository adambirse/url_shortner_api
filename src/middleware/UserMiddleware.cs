public class UserMiddleware
{
    private readonly RequestDelegate _next;

    public UserMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var user = context.User;
        Console.WriteLine("User has role Admin?: " + user.IsInRole("Admin"));

        await _next(context);
    }
}
