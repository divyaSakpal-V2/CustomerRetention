namespace CustomerRetention.Models
{
    public class CustomerSegment
    {
        public int year { get; set; }

        public List<CustomerLoyalty> customerLoyalties { get; set; }

    }
}
