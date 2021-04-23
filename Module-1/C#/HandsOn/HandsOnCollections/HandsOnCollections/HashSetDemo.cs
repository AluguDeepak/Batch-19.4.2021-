using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class HashSetDemo
    {
        static void Main()
        {
            HashSet<int> set2 = new HashSet<int>() { 12, 23, 56, 67, 45 };
            HashSet<int> set1 = new HashSet<int>();
            set1.Add(10);
            set1.Add(34);
            set1.Add(45);
            set1.Add(34);
           
            Console.WriteLine();
            // set1.IntersectWith(set2);
            //set1.UnionWith(set2); //set2 merge with set1
            set1.ExceptWith(set2);
            foreach (int k in set1)
                Console.WriteLine(k);

        }
    }
}
