using AutoMapper;
using Eventora.Application.Contracts.Customers;
using Eventora.Domain.Customers;
using Eventora.Domain.Tenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Customers
{
    public class CustomersService : ICustomersService
    {
        private readonly CustomerManager _customerManager;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomersService(ICustomerRepository customerRepository, IMapper mapper, CustomerManager customerManager)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerManager = customerManager;
        }

        public async Task<CustomerDto> CreateAsync(CreateCustomersDto customersDto)
        {
            var customer = await _customerManager.CreateAsync(customersDto.FullName, customersDto.Phone, customersDto.Email);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<CustomerDto?> GetAsync(Guid id)
        {
            var customer =  await _customerRepository.GetAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<IReadOnlyList<CustomerDto>> GetListAsync()
        {
            var customer = await _customerRepository.GetListAsync();
            return _mapper.Map<IReadOnlyList<CustomerDto>> (customer);
        }
    }
}
