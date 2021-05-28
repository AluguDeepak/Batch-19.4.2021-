using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo1
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7,7, 8, 9,6 };
            var query = numbers.ToLookup(i => i % 2);
            foreach (IGrouping<int, int> group in query)
            {
                Console.WriteLine("Key: {0}", group.Key);
                foreach (int number in group)
                {
                   // Console.WriteLine(number);
                }
            }
            //return uniq values
            var query1=(from i in numbers select i).Distinct();
            var query2 = numbers.Distinct();
            foreach (var i in query2)
                Console.WriteLine(i);
        }
    }
}
