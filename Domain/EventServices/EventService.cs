using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using Eventora.Domain.Events;
using Eventora.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.EventServices
{
    public class EventService : BaseEntity<Guid> , IMultiTenant
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }

        public Guid ServiceId { get; set; }
        public Service Service { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal Price { get; set; }  

        public string? Notes { get; set; }

        public decimal Total => Price * Quantity;

        public Guid? TenantId { get; set; }
    }
}
