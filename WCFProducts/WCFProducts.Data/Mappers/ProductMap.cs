using System.Collections.Generic;
using System.Data.SqlClient;
using WCFProducts.Data.Entities;

namespace WCFProducts.Data.Mappers
{
    public class ProductMap
    {
        public ProductMap()
        {}

        public Product ConvertDataReaderToProductObject(SqlDataReader reader)
        {
            var product = new Product();

            while (reader.Read())
            {
                product.Id = int.Parse(reader["id"].ToString());
                product.Name = reader["name"].ToString();
                product.Description = reader["description"].ToString();
                product.Price = decimal.Parse(reader["price"].ToString());
                
                break;
            }

            return product;
        }

        public List<Product> ConvertDataReaderToProductObjectList(SqlDataReader reader)
        {
            var products = new List<Product>();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Name = reader["name"].ToString(),
                    Description = reader["description"].ToString(),
                    Price = decimal.Parse(reader["price"].ToString())
                });
            }

            return products;
        }
    }
}
