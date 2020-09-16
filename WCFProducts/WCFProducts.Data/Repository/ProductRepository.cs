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
        private readonly ProductMapper _productMapper;

        public ProductRepository()
        {
            _context = new SqlContext();
            _productMapper = new ProductMapper();
        }

        public async Task<Product> InsertProduct(Product product)
        {
            string procedureName = "USP_INSERT_PRODUCT";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            parammeters.Add("@NAME", product.Name);
            parammeters.Add("@DESCRIPTION", product.Description);
            parammeters.Add("@PRICE", product.Price);

            var productReader = await _context.ExecuteProcedureWithReader(procedureName, parammeters);

            return _productMapper.ConvertDataReaderToProductObject(productReader);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            string procedureName = "USP_UPDATE_PRODUCT";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            parammeters.Add("@ID", product.Id);
            parammeters.Add("@NAME", product.Name);
            parammeters.Add("@DESCRIPTION", product.Description);
            parammeters.Add("@PRICE", product.Price);

            var productReader = await _context.ExecuteProcedureWithReader(procedureName, parammeters);

            return _productMapper.ConvertDataReaderToProductObject(productReader);
        }

        public async Task DeleteProduct(int id)
        {
            string procedureName = "USP_DELETE_PRODUCT";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            parammeters.Add("@ID", id);

            await _context.ExecuteProcedure(procedureName, parammeters);
        }

        public async Task<Product> GetProduct(int id)
        {
            string procedureName = "USP_SELECT_PRODUCT";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            parammeters.Add("@ID", id);

            var productReader = await _context.ExecuteProcedureWithReader(procedureName, parammeters);

            return _productMapper.ConvertDataReaderToProductObject(productReader);
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            string procedureName = "USP_SELECT_ALL_PRODUCTS";

            Dictionary<string, dynamic> parammeters = new Dictionary<string, dynamic>();

            var productReader = await _context.ExecuteProcedureWithReader(procedureName, parammeters);

            return _productMapper.ConvertDataReaderToProductObjectList(productReader);
        }
    }
}
