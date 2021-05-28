using System;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 12, 23, 34, 45, 56, 67, 78, 89 };
            //fetch even values
            //IEnumerable<int> result = from i in no 
            //                          where i % 2 == 0
            //                          select i;
            var result = from i in no where i > 40 && i%2!=0 select i;
            no[1] = 24;
            var result_sorting = from i in no where i > 30 orderby i select i;
            var result_reverse = (from i in no where i > 20 select i).Reverse();
            //deffered execuation
            foreach (var item in result_reverse)
                Console.WriteLine(item);
            Console.ReadKey();

        }
    }
}
