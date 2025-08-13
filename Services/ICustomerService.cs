using CustomerRetention.Models;

namespace CustomerRetention.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerSegment>> GetLoyalty();
    }
}
