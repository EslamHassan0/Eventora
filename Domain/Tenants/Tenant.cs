using Eventora.Domain.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Tenants
{
    public class Tenant : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string SubscriptionType { get; set; }

        public Tenant(string name, string phone, string email, string address, bool isActive, string subscriptionType)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            IsActive = isActive;
            SubscriptionType = subscriptionType;
        }
    }
}
