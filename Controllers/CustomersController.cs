using CustomerRetention.Models;
using CustomerRetention.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRetention.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
      
        readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("loyalty")]
        public async Task<List<CustomerSegment>> GetLoyaltyTier()
        {
          return await _customerService.GetLoyalty();
        }
    }
}
