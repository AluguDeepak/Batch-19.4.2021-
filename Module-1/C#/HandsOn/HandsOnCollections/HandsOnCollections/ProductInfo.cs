using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class ProductInfo
    {
        public List<Product> products;
        public ProductInfo()
        {
            products = new List<Product>()
            {
                new Product(){Pid=1,Pname="Mouse",Price=500,Stock=10}
            };
        }
        //Add Product
        public void AddProduct(Product product)
        {
            products.Add(product);
            // products = products.OrderBy(i => i.Pid).ToList();
            products = (from i in products
                        orderby i.Pid
                        select i).ToList();
        }
        //Get Product by Name
        public Product GetProduct(string name)
        {
            Product product = null;
            foreach(Product p in products)
            {
                if(p.Pname.Equals(name))
                {
                    product = p;
                }
            }
            return product;
        }
        //Get All the Products
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool DeleteProduct(int pid)
        {
            Product product = null;
            foreach(Product p in products)
            {
                if (p.Pid == pid)
                {
                    product = p;
                    break;
                }
            }
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProduct(int pid,double price,int stock)
        {
            Product product = null;
            foreach (Product p in products)
            {
                if (p.Pid == pid)
                {
                    product = p;
                    break;
                }
            }
            if (product != null)
            {
                products.Remove(product);
                product.Price = price;
                product.Stock = stock;
                products.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
