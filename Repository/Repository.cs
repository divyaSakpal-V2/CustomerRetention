using CustomerRetention.Models;

namespace CustomerRetention.Repository
{
    public class Repository : IRepository
    {
        readonly LoyaltyMaster _loyaltymaster;
        readonly List<Purchase> _purchases;
        public Repository()
        {
            _loyaltymaster = new LoyaltyMaster()
            {
                loyalties = new List<Loyalty>() {
            new Loyalty
            {
                Tier = "Silver",
                Min = 1
            },
            new Loyalty
            {
                Tier = "Gold",
                Min = 6
            },
            new Loyalty
            {
                Tier = "Platinum",
                Min = 12
            } }
            };

            _purchases =
             [
             new Purchase { CustomerId = "C001", Amount = 1500, PurchaseDate = new DateTime(2023, 01, 15) },
             new Purchase { CustomerId = "C002", Amount = 2500, PurchaseDate = new DateTime(2023, 02, 20) },
             new Purchase { CustomerId = "C001", Amount = 3000, PurchaseDate = new DateTime(2023, 03, 05) },
             new Purchase { CustomerId = "C003", Amount = 700, PurchaseDate = new DateTime(2023, 04, 25) },
             new Purchase { CustomerId = "C002", Amount = 5500, PurchaseDate = new DateTime(2023, 05, 15) },
             new Purchase { CustomerId = "C001", Amount = 3200, PurchaseDate = new DateTime(2023, 06, 10) },
             new Purchase { CustomerId = "C003", Amount = 1000, PurchaseDate = new DateTime(2023, 07, 22) },
             new Purchase { CustomerId = "C004", Amount = 400, PurchaseDate = new DateTime(2023, 08, 30) },

             ];
        }

        public async Task<List<CustomerSegment>> Get()
        {
          var result=  _purchases.GroupBy(y => y.PurchaseDate.Year).Select(yrgrp => new CustomerSegment()
            {
                year = yrgrp.Key,
                customerLoyalties = yrgrp.GroupBy(cust => cust.CustomerId).Select(grp =>
                new CustomerLoyalty()
                {
                    customerId = grp.Key,
                    Tier = _loyaltymaster.loyalties.OrderByDescending(l => l.Min).First(y => y.Min <= grp.Count()).Tier
                }).ToList()
            });






         

            return result.ToList();
        }
    }
}
