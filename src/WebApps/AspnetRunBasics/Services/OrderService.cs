using AspnetRunBasics.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRunBasics.Services
{
    public class OrderService : IOrderService
    {
        public Task<IEnumerable<OrderResponseModel>> GetOrdersByUsername(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}
