using System;
using HandsOnEFCore_DataBaseFirst.Entities;
using HandsOnEFCore_DataBaseFirst.Repositories;
using HandsOnEFCore_DataBaseFirst.GenericRepository;
namespace HandsOnEFCore_DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Menu();
            //} while (true);
            // GenericRepository<Product> repository = new GenericRepository<Product>();
            //foreach (var item in repository.GetAll())
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", item.Pid, item.Pname, item.Price, item.Stock);
            //}
            GenericRepository<Employee> repository = new GenericRepository<Employee>();
            foreach(var item in repository.GetAll())
            {
                Console.WriteLine("{0} {1}",item.Eid,item.Ename);
            }
           

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
                    case 3:
                        {
                            var item = repository.GetProduct(100);
                            Console.WriteLine("{0} {1} {2} {3}", item.Pid, item.Pname, item.Price, item.Stock);
                        }
                        break;
                    case 4:
                        {
                            repository.DeleteProduct(100);
                        }
                        break;
                    case 5:
                        {
                            var item= repository.GetProduct(100);
                            item.Price = 450;
                            item.Stock = 100;
                            repository.UpdateProduct(item);
                        }
                        break;
                    case 6:
                        {
                            Environment.Exit(0);
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
