using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNullableTypes
{
    class Program
    {
        public static void AddProduct(Product product)
        {
            //Add Product details to db table
        }
        static void Main(string[] args)
        {
            Nullable<int> Price = null;
            int? i = null;
            double? d = null;
            //Assing nullable type value to non nullable type
            int k = i??0;
            i = 20;
            k = i ?? 0;
            Product p = new Product();
            p.Pid = 100;
            p.Pname = null;
            p.Price = null;
            p.Stock = null;
            Console.WriteLine($"Price:{p.Price} Stock:{p.Stock}");
            AddProduct(p);
        }
    }
}
