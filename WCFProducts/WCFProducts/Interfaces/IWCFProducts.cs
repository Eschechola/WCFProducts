using System.ServiceModel;
using WCFProducts.Data.DTO;
using System.Collections.Generic;

namespace WCFProducts.Interfaces
{
    [ServiceContract]
    public interface IWCFProducts
    {
        [OperationContract]
        ProductDTO InsertCustomer(ProductDTO productDTO);

        [OperationContract]
        ProductDTO UpdateCustomer(ProductDTO productDTO);

        [OperationContract]
        void DeleteCustomer(int id);

        [OperationContract]
        ProductDTO GetCustomer(int id);

        [OperationContract]
        IList<ProductDTO> GetAllCustomers();
    }
}
