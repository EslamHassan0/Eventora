
using Eventora.Domain.Tenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Contracts.Tenants
{
    public interface ITenantService
    {
        Task<Tenant> CreateAsync(CreateTenantDto createTenant);
        Task<Tenant?> GetCurrentTenantAsync();

    }
}
