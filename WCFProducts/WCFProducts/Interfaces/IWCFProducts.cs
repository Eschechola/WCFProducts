using System.ServiceModel;
using WCFProducts.Data.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WCFProducts.Interfaces
{
    [ServiceContract]
    public interface IWCFProducts
    {
        [OperationContract]
        Task<Product> InsertProduct(Product product);

        [OperationContract]
        Task<Product> UpdateProduct(Product product);

        [OperationContract]
        Task DeleteProduct(int id);

        [OperationContract]
        Task<Product> GetProduct(int id);

        [OperationContract]
        Task<IList<Product>> GetAllProducts();
    }
}
