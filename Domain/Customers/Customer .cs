using Eventora.Domain.Common.BaseEntity;
using Eventora.Domain.Common.MultiTenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Customers
{
    public class Customer : BaseEntity<Guid>, IMultiTenant
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid? TenantId { get; set; }

        public Customer(string fullName, string phone, string email)
        {
            FullName = fullName;
            Phone = phone;
            Email = email;
            
        }
    }
}
