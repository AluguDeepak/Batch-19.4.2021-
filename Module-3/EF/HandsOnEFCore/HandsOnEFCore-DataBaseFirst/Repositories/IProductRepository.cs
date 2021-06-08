using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFCore_DataBaseFirst.Entities;
namespace HandsOnEFCore_DataBaseFirst.Repositories
{
    interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
    }
}
