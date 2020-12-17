using IntelligentGrowthSolutions.Marketplace.Data;
using IntelligentGrowthSolutions.Marketplace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IntelligentGrowthSolutions.Marketplace.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts(CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking().ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<Product> GetByProductId(int product_id, CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(e => e.Id == product_id, cancellationToken).ConfigureAwait(false);
        }

        public async Task<Product> AddProduct(Product product, CancellationToken cancellationToken)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync(cancellationToken);
            return product;
        }

        public async Task<Product> UpdateProduct(Product product, CancellationToken cancellationToken)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
            return product;
        }

        public async Task DeleteProduct(int product_id, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.SingleOrDefaultAsync(e => e.Id == product_id, cancellationToken);

            if (entity != null)
            {
                _context.Products.Remove(entity);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
