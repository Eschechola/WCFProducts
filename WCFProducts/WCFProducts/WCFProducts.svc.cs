using System;
using WCFProducts.Interfaces;
using WCFProducts.Data.Entities;
using WCFProducts.Data.Interfaces;
using WCFProducts.Data.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WCFProducts
{
    public class WCFProducts : IWCFProducts
    {
        private readonly IProductRepository _productRepository;

        public WCFProducts()
        {
            _productRepository = new ProductRepository();
        }

        public async Task<Product> InsertProduct(Product product)
        {
            try
            {
               return await _productRepository.InsertProduct(product);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                return await _productRepository.UpdateProduct(product);

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task DeleteProduct(int id)
        {
            try
            {
                await _productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {}
        }

        public async Task<Product> GetProduct(int id)
        {
            try
            {
                return await _productRepository.GetProduct(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            try
            {
                return await _productRepository.GetAllProducts();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
