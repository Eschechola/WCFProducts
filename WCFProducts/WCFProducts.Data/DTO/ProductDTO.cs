using System.Runtime.Serialization;

namespace WCFProducts.Data.DTO
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
        
        [DataMember]
        public decimal Price { get; set; }
    }
}
