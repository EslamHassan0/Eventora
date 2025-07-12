using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Common.MultiTenants
{
    public interface IMultiTenant
    {
        public Guid? TenantId { get; set; } 
    }
}
