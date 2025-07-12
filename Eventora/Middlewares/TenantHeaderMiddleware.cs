public class TenantHeaderMiddleware
{
    private readonly RequestDelegate _next;

    public TenantHeaderMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        
        if (context.Request.Path.StartsWithSegments("/api/tenants") && context.Request.Method == "POST")
        {
            await _next(context);
            return;
        }

        
        if (context.Request.Headers.TryGetValue("tenant", out var tenantIdHeader) &&
            Guid.TryParse(tenantIdHeader, out var tenantId))
        {
            context.Items["TenantId"] = tenantId;
            await _next(context);
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsync("Tenant Id is required.");
        }
    }
}
