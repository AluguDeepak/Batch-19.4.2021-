using System;
using HandsOnEFCore_DataBaseFirst.Entities;
using HandsOnEFCore_DataBaseFirst.Repositories;
namespace HandsOnEFCore_DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Menu();
            } while (true);

        }

        private static void Menu()
        {
            ProductRepository repository = new ProductRepository();
            try
            {
                Console.WriteLine("1.AddProduct");
                Console.WriteLine("2.GetProducts");
                Console.WriteLine("3.GetProductById");
                Console.WriteLine("4.DeleteProduct");
                Console.WriteLine("5.UpdateProduct");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            repository.AddProduct(new Product()
                            {
                                Pid = 100,
                                Pname = "AAA",
                                Price = 300,
                                Stock = 20
                            });
                        }
                        break;
                    case 2:
                        {
                            foreach(var item in repository.GetProducts())
                            {
                                Console.WriteLine("{0} {1} {2} {3}",item.Pid,item.Pname,item.Price,item.Stock);
                            }
                        }
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
