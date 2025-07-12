using Eventora.Domain.Tenants;
using Eventora.Infrastructure.EventoraDBContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Infrastructure.Repository
{
    public class TenantRepository : ITenantRepository
    {
        private readonly EventoraDBContext _context;
        public TenantRepository(EventoraDBContext context)
        {
            _context = context;
        }

        public async Task<Tenant> GetAsync(Guid id)
        {
            var currentTenant = await _context.Tenants.FindAsync(id);
            return currentTenant == null ? 
                throw new Exception("Not Found this tenant") : 
                currentTenant;
        }

        public async Task<List<Tenant>> GetTenantInfoAsync()
        {
            return await _context.Tenants.ToListAsync();
        }

        public async Task<Tenant> InsertAsync(Tenant tenant)
        {
            await _context.Tenants.AddAsync(tenant);
            await _context.SaveChangesAsync();
            return tenant;
        }
    }
}
