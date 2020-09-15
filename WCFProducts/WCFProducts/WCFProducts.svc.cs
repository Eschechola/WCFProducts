using WCFProducts.Data.DTO;
using WCFProducts.Interfaces;
using System.Collections.Generic;

namespace WCFProducts
{
    public class WCFProducts : IWCFProducts
    {
        public ProductDTO InsertCustomer(ProductDTO productDTO)
        {
            return new ProductDTO();
        }

        public ProductDTO UpdateCustomer(ProductDTO productDTO)
        {
            return new ProductDTO();
        }

        public void DeleteCustomer(int id)
        {
            
        }

        public ProductDTO GetCustomer(int id)
        {
            return new ProductDTO();
        }

        public IList<ProductDTO> GetAllCustomers()
        {
            return new List<ProductDTO>();
        }
    }
}
