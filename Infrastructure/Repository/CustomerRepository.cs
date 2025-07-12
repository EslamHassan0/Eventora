using Eventora.Domain.Customers;
using Eventora.Domain.Tenants;
using Eventora.Infrastructure.EventoraDBContexts;
using Microsoft.EntityFrameworkCore;

namespace Eventora.WebAPi
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly EventoraDBContext _context;
        public CustomerRepository(EventoraDBContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer;
        }

        public async Task<IReadOnlyList<Customer>> GetListAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> InsertAsync(Customer customer)
        {
           await _context.AddAsync(customer);
           await _context.SaveChangesAsync();
           return customer;
        }
    }
}
