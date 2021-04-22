using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class Demo3
    {
        static void Main()
        {
            ArrayList list = new ArrayList()
            {
                "Rose",
                "Lilly",
                "Jasmine",
                "Tulips",
                "MariGold"
            };
            Console.WriteLine("No of Flowers:{0}", list.Count);
            //search flower
            list.Sort();
            Console.WriteLine("Enter Flower name");
            string flr = Console.ReadLine();
            if (list.BinarySearch(flr) >= 0)
            {
                Console.WriteLine("Flower exist in the Garden");
                Console.WriteLine("Flower at {0} Position", list.BinarySearch(flr));
            }
            else
                Console.WriteLine("Comeback next time..");
        }
    }
}
