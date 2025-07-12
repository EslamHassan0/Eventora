using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Tenants
{
    public interface ITenantRepository
    {
        Task<List<Tenant>> GetTenantInfoAsync();
        Task<Tenant> GetAsync(Guid id);

        Task<Tenant> InsertAsync(Tenant tenant);
    }
}
