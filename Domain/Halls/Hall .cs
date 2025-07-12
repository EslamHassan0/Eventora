using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Halls
{
    public class Hall : BaseEntity<Guid>, IMultiTenant
    {
        public string  Name { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public string PricePerHour { get; set; }
        public bool IsAvailable { get; set; }
        public Guid? TenantId { get; set; }
        public Hall(string name, int capacity, string location, string pricePerHour, bool isAvailable, Guid? tenantId)
        {
            Name = name;
            Capacity = capacity;
            Location = location;
            PricePerHour = pricePerHour;
            IsAvailable = isAvailable;
            TenantId = tenantId;
        }
    }
}
