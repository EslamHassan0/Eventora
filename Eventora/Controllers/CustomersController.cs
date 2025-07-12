using Eventora.Application.Contracts.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventora.WebAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;
        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        {
            var customer = await _customersService.GetListAsync();
            return Ok(customer);
        }
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var customer = await _customersService.GetAsync(id);
            return customer == null ?  NotFound() :  Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateCustomersDto customerDto)
        {
            var customer = await _customersService.CreateAsync(customerDto);
            return Ok(customer);
        }
    }
}
