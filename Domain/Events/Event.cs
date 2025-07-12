using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using Eventora.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Events
{
    public class Event : BaseEntity<Guid>, IMultiTenant
    {

        public string Title { get; set; }
        public EventType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EventStatus Status { get; set; }
        public int GuestCount { get; set; }
        public string Description { get; set; }
        public Guid? TenantId { get; set; }
        public Event(string title, EventType type, DateTime startDate, DateTime endDate, EventStatus status, int guestCount, string description, Guid? tenantId)
        {
            Title = title;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            GuestCount = guestCount;
            Description = description;
            TenantId = tenantId;
        }
    }
}
