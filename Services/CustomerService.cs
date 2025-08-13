using CustomerRetention.Models;
using CustomerRetention.Repository;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace CustomerRetention.Services
{
    public class CustomerService : ICustomerService
    {
        readonly IRepository _repository;
        public CustomerService(IRepository repository) {
            _repository = repository;
        }
        public async Task<List<CustomerSegment>> GetLoyalty()
        {
           return await _repository.Get();
        }
    }
}
