using System.Collections.Generic;
using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IProductRepository
    {
         Task<Product> GetProductByIdAsync(int id);
         Task<IReadOnlyList<Product>> GetProductsAsync();
         Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
         Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}