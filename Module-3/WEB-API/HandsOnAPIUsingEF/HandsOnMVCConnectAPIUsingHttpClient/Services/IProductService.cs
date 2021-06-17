using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCConnectAPIUsingHttpClient.Models;
namespace HandsOnMVCConnectAPIUsingHttpClient.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
    }
}
