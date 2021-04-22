using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class Demo2
    {
        static void Main()
        {
            ArrayList list = new ArrayList() { 12, 34, 5, 68, 65, 43, 32, 21 }; //collection initializer
            list.Add(90);
            list.Insert(0, 9);
            //ArrayList list1 = new ArrayList();
            //for(int i=1;i<=10;i++)
            //{
            //    Console.WriteLine("Enet value {0}", i);
            //    list1.Add(Console.ReadLine());
            //}
            //list1.Add(900);
            //foreach (object o in list1)
            //    Console.WriteLine(o);
            list.Sort();
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //search item
           
        }
    }
}
