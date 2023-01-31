using Catalog.API.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetProductsByName(string name);
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductByCategory(string name);
        Task CreateProduct (Product product);   
        Task<bool> UpdateProduct(Product product);  
        Task<bool> DeleteProduct(string id);
    }
}
