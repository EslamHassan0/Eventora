using Eventora.Domain.Shared.Settings.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Shared.Settings.TenantSettings
{
    public class TenantSetting
    {
        public Configuration Defaults { get; set; } = default!;
        //public List<Tenant> Tenants { get; set; } = new();
    }
}
