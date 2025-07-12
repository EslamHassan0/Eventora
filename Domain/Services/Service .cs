using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using Eventora.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Services
{
    public class Service : BaseEntity<Guid>, IMultiTenant
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ServiceCategory Category { get; set; }
        public Guid? TenantId { get; set; }
    }
}
