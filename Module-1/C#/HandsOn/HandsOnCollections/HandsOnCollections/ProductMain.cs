using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class ProductMain
    {
        static void Main()
        {
            ProductInfo productInfo = new ProductInfo();
            do
            {
                Console.WriteLine("1.Add Products");
                Console.WriteLine("2.GetProduct By Name");
                Console.WriteLine("3.List All the Products");
                Console.WriteLine("4.DeleteProduct");
                Console.WriteLine("5.UpdateProduct");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        {
                            Product p=GetDetails();
                            productInfo.AddProduct(p);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Product Name");
                            string pname = Console.ReadLine();
                            Product product = productInfo.GetProduct(pname);
                            if (product != null)
                            {
                                Console.WriteLine("Price: " + product.Price);
                                Console.WriteLine("Availability: " + product.Stock);
                            }
                            else
                                Console.WriteLine("Product Not Exist");
                        }
                        break;
                    case 3:
                        {
                            List<Product> products = productInfo.GetProducts();
                            foreach(Product p in products )
                            {
                                Console.WriteLine("{0} {1} {2} {3}", p.Pid, p.Pname, p.Price, p.Stock);
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter Produt Id");
                            int Id = int.Parse(Console.ReadLine());
                            if (productInfo.DeleteProduct(Id))
                            {
                                Console.WriteLine("Product Removed.");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Produt Id");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter New Price");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter  New  Stock");
                            int stock = int.Parse(Console.ReadLine());
                            if (productInfo.UpdateProduct(id,price,stock))
                            {
                                Console.WriteLine("Product Updated.");
                            }
                            else
                                Console.WriteLine("Invalid Id");
                        }
                        break;
                    case 6:
                        {
                            Environment.Exit(0);
                        }
                        break;
                           
                        
                }
            } while (true);
        }

        private static Product GetDetails()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Details");
            Console.WriteLine("Enter Id");
             product.Pid= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            product.Pname= Console.ReadLine();
            Console.WriteLine("Enter Price");
            product.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock");
            product.Stock = int.Parse(Console.ReadLine());
            return product;

        }
    }
}
