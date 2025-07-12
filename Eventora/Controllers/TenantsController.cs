using Eventora.Application.Contracts.Tenants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventora.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantsController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentTenantAsync()
        {
            var tenant =   await _tenantService.GetCurrentTenantAsync();

            return Ok(tenant);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateTenantDto createTenantDto)
        {
            var tenant = await _tenantService.CreateAsync(createTenantDto);

            return Ok(tenant);
        }
    }
}
