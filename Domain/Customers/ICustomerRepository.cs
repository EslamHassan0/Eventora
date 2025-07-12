using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> GetAsync(Guid id);
        Task<IReadOnlyList<Customer>> GetListAsync();
        Task<Customer> InsertAsync(Customer  customer);
    }
}
