using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger) 
        { 
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrdrers());
                await orderContext.SaveChangesAsync();
                logger.LogInformation($"Seeded database assosciated with context {typeof(OrderContext).Name} ");
            }      
        }

        private static IEnumerable<Order> GetPreconfiguredOrdrers() {
            return new List<Order>
            {
                new Order() {UserName="swn",FirstName="Delight",LastName="Sekhwela", EmailAddress="25sekhwelad@gmail.com", AddressLine="Kempton Park", Country="South Africa",TotalPrice=350}
            };       
        }
    }
}
