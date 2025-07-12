using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using Eventora.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Bookings
{
    public class Booking : BaseEntity<Guid>, IMultiTenant
    {
        public Guid EventId { get; set; }
        public Guid HallId { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal Price { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Guid? TenantId { get; set ; }
        public Booking(Guid eventId, Guid hallId, DateTime bookingDate, decimal price, PaymentStatus paymentStatus, Guid? tenantId)
        {
            EventId = eventId;
            HallId = hallId;
            BookingDate = bookingDate;
            Price = price;
            PaymentStatus = paymentStatus;
            TenantId = tenantId;
        }
    }
}
