using HandsOnAPIUsingEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.DBContext;
namespace HandsOnAPIUsingEF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private MyContext _context = null;
        public ProductRepository(MyContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
          return _context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
