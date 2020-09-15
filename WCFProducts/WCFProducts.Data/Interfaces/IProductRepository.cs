using System.Collections.Generic;
using System.Threading.Tasks;
using WCFProducts.Data.Entities;

namespace WCFProducts.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> InsertProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(int id);
        Task<Product> GetProduct(int id);
        Task<IList<Product>> GetAllProducts();
    }
}
