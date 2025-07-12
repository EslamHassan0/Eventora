using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Shared.Settings.Tenants
{
    public class Tenant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? ConnectionString { get; set; }
    }
}
