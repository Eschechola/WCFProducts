using System.Collections.Generic;
using System.Threading.Tasks;
using WCFProducts.Data.Context;
using WCFProducts.Data.Entities;
using WCFProducts.Data.Interfaces;
using WCFProducts.Data.Mappers;

namespace WCFProducts.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlContext _context;

        public ProductRepository()
        {
            _context = new SqlContext();
        }

        public async Task<Product> InsertProduct(Product product)
        {
            string procedureName = "USP_INSERT_PRODUCT";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            parammeters.Add("@NAME", product.Name);
            parammeters.Add("@DESCRIPTION", product.Description);
            parammeters.Add("@PRICE", product.Price);

            var productReader = await _context.ExecuteProcedureWithReader(procedureName, parammeters);

            var productInserted = new ProductMap().ConvertDataReaderToProductObject(productReader);

            return productInserted;
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Product>> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
