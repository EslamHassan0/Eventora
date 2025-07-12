using Eventora.Application.Contracts.Tenants;
using Eventora.Domain.Tenants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Tenants
{
    public class TenantService : ITenantService
    {
        private Tenant? _currentTenant;
        private HttpContext _httpContext;
        private readonly ITenantRepository _tenantRepository;
        //public TenantService(IHttpContextAccessor httpContextAccessor,
        //    ITenantRepository tenantRepository)
        //{
        //    _httpContext = httpContextAccessor.HttpContext;
        //    _tenantRepository = tenantRepository;
        //    if (_httpContext is not null &&
        //         _httpContext.Request.Path != "/api/Tenants" &&  
        //         _httpContext.Request.Method != "POST")
        //    {
        //        if (_httpContext.Request.Headers.TryGetValue("tenant", out var keyValueId))
        //        {
        //            if(Guid.TryParse(keyValueId , out var tenantId))
        //            {
        //             SetCurrentTenant(tenantId!);

        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("No Tenant Provided !");
        //        }
        //    }


        //}

        public TenantService(IHttpContextAccessor httpContextAccessor, ITenantRepository tenantRepository)
        {
            _httpContext = httpContextAccessor.HttpContext;
            _tenantRepository = tenantRepository;
        }

        public async Task<Tenant?> GetCurrentTenantAsync()
        {
            var context = _httpContext;
            if (context?.Items.TryGetValue("TenantId", out var value) == true && value is Guid tenantId)
            {
                var tenant = await _tenantRepository.GetAsync(tenantId);
                return tenant;
            }
            return null;
        }

 
        public async Task<Tenant> CreateAsync(CreateTenantDto createTenant)
        {
            var newTenant = new Tenant(createTenant.Name,createTenant.Phone ,
                createTenant.Email , createTenant.Address , createTenant.IsActive , createTenant.SubscriptionType);

           return await _tenantRepository.InsertAsync(newTenant);

        }
        private async Task SetCurrentTenant(Guid tenantId)
        {
            _currentTenant = await _tenantRepository.GetAsync(tenantId);
            if (_currentTenant == null)
                throw new Exception("Invalid TenantId !");

            //if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
            //    _currentTenant.ConnectionString = _tenantSetting.Defaults.ConnectionString;
        }
    }
}
