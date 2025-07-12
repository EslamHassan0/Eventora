using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Domain.Customers
{
    public class CustomerManager
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> CreateAsync(string fullName, string phone, string email)
        {
            var  customer = new Customer(fullName, phone, email);

           return await _customerRepository.InsertAsync(customer);
        }
    }
}
