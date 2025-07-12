using Eventora.Application.Contracts.Tenants;
using Eventora.Infrastructure.EventoraDBContexts;

namespace Eventora.WebAPi.Middlewares
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context, ITenantService tenantService, EventoraDBContext dbContext)
        {

             
            var tenant = await tenantService.GetCurrentTenantAsync();
            if (tenant != null)
            {
                dbContext.SetTenant(tenant.Id);
            }

            await _next(context);
        }
    }
}
