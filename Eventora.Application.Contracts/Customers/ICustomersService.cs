using Eventora.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Contracts.Customers
{
    public interface ICustomersService
    {
        Task<CustomerDto> CreateAsync(CreateCustomersDto customersDto);

        Task<CustomerDto?> GetAsync(Guid id);

        Task<IReadOnlyList<CustomerDto>> GetListAsync();
    }
}
