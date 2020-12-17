using IntelligentGrowthSolutions.Marketplace.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IntelligentGrowthSolutions.Marketplace.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts(CancellationToken cancellationToken);
        Task<Product> GetByProductId(int product_id, CancellationToken cancellationToken);
        Task<Product> AddProduct(Product product, CancellationToken cancellationToken);
        Task<Product> UpdateProduct(Product product, CancellationToken cancellationToken);
        Task DeleteProduct(int product_id, CancellationToken cancellationToken);
    }
}
