using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class HashTableDemo2
    {
        static void Main()
        {
            Product p = new Product() { Pid = 1, Pname = "Keyboard", Price = 100, Stock = 100 };
            Product p2 = new Product() { Pid = 2, Pname = "Mouse", Price = 400, Stock = 100 };
            Product p1= new Product() { Pid = 3, Pname = "KeyPad", Price = 100, Stock = 100 };
            Hashtable hs = new Hashtable();
            hs.Add(p.Pid, p);
            hs.Add(p1.Pid, p1);
            hs.Add(p2.Pid, p2);
            Product product = hs[p.Pid] as Product;
            Console.WriteLine("No of Products {0}", hs.Count);
            hs.Remove(1);
            foreach(DictionaryEntry d in hs)
            {
                //Product pp = d.Value as Product;
                Product pp = (Product)d.Value;
                Console.WriteLine("Product {0} Details {1} {2} {3}", d.Key, pp.Pname, pp.Price,pp.Stock);
            }
        }
    }
}
