using HandsOnEFCore_DataBaseFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCore_DataBaseFirst.Repositories
{
    class ProductRepository : IProductRepository
    {
        private Batch2DBContext db = null;
      public ProductRepository()
        {
            db = new Batch2DBContext();
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList(); //select * from product
        }

        public void UpdateProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
        public void UpdateProduct(int id, int price)
        {
           Product product= db.Products.Find(id);
            product.Price = price;
            db.SaveChanges();
        }
    }
}
