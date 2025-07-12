using AutoMapper;
using Eventora.Application.Contracts.Customers;
using Eventora.Domain.Customers;
using Eventora.Domain.Tenants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Application.Customers.CustomerMappers
{
    public class CustomerMapper  : Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
