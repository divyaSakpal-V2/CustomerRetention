# CustomerRetention
# Story: Customer Loyalty Analysis
#
# As a data analyst, categorize customers based on their purchasing frequency over the last year to enhance customer retention strategies.
#
# Acceptance Criteria:
# 1. Data Access:
#    - Fetch customer purchase frequency data from ECommerceApplication.Data.Db.CustomerActivities.
#
# 2. Segmentation Logic:
#    - Segment customers based on their purchase frequency into three loyalty tiers:
#      - Platinum (12 or more purchases per year)
#      - Gold (6 to 11 purchases per year)
#      - Silver (1 to 5 purchases per year).
#
# 3. Return Data:
#    - Return a list showing each customer's loyalty tier.
#
# Example API Request:
GET http://localhost:5141/customers/loyalty
# Expected JSON Output:
# [
#   {
#     "customerId": "C001",
#     "loyaltyTier": "Gold"
#   },
#   {
#     "customerId": "C002",
#     "loyaltyTier": "Platinum"
#   },
#   {
#     "customerId": "C003",
#     "loyaltyTier": "Silver"
#   },
#   {
#     "customerId": "C004",
#     "loyaltyTier": "Silver"
#   }
# ]
 
 
---------------------------------------------------------------------------------------------------------------------------------------
 
 
Data :  
   public static readonly List<Purchase> Purchases =
   [
       new Purchase { CustomerId = "C001", Amount = 1500, PurchaseDate = new DateTime(2023, 01, 15) },
       new Purchase { CustomerId = "C002", Amount = 2500, PurchaseDate = new DateTime(2023, 02, 20) },
       new Purchase { CustomerId = "C001", Amount = 3000, PurchaseDate = new DateTime(2023, 03, 05) },
       new Purchase { CustomerId = "C003", Amount = 700, PurchaseDate = new DateTime(2023, 04, 25) },
       new Purchase { CustomerId = "C002", Amount = 5500, PurchaseDate = new DateTime(2023, 05, 15) },
       new Purchase { CustomerId = "C001", Amount = 3200, PurchaseDate = new DateTime(2023, 06, 10) },
       new Purchase { CustomerId = "C003", Amount = 1000, PurchaseDate = new DateTime(2023, 07, 22) },
       new Purchase { CustomerId = "C004", Amount = 400, PurchaseDate = new DateTime(2023, 08, 30) }
   ];
