using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Contracts.Tenants
{
    public class CreateTenantDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string SubscriptionType { get; set; }
    }
}
