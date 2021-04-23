using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class DictionaryDemo
    {
        static void Main()
        {
            //Dictionary is a collectio of keyvalue pairs
            Product p = new Product() { Pid = 10, Pname = "Keyboard", Price = 100, Stock = 100 };
            Product p2 = new Product() { Pid = 2, Pname = "Mouse", Price = 400, Stock = 100 };
            Product p1 = new Product() { Pid = 3, Pname = "KeyPad", Price = 100, Stock = 100 };
            //Dictionary<int, Product> list = new Dictionary<int, Product>();
            SortedDictionary<int, Product> list = new SortedDictionary<int, Product>();
            list.Add(p.Pid, p);
            list.Add(p1.Pid, p1);
            list.Add(p2.Pid, p2);
            Product product = list[10];
            foreach(KeyValuePair<int,Product> k in list)
            {
                Console.WriteLine("Product Details of {0} is {1}-{2}-{3}", k.Key, k.Value.Pname, k.Value.Price, k.Value.Stock);
            }
            Dictionary<char, string> Dic = new Dictionary<char, string>()
            {
                {'a',"America" },
                {'b',"Bombay" },
                {'c',"Canada" }
            };
            string s = Dic['a'];
        }
    }
}
