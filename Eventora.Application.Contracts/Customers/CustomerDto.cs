using Eventora.Domain.Common.BaseDto;
using Eventora.Domain.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Contracts.Customers
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
