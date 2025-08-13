using CustomerRetention.Models;

namespace CustomerRetention.Repository
{
    public interface IRepository
    {
        Task<List<CustomerSegment>> Get();
    }
}
