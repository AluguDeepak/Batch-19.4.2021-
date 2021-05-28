using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo2
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 6 };
            var result1 = numbers.OrderBy(i => i);
            result1= numbers.OrderByDescending(i => i);
            result1 = numbers.Where(i => i > 10).OrderByDescending(i => i);
            //immeidate execution
            int[] a = (from i in numbers where i % 2 == 0 select i).ToArray();
            int[] b = numbers.Where(i => i % 2 == 0).ToArray();
            List<int> result = numbers.Where(i => i % 2 != 0).ToList();
            numbers[0] = 10;
            foreach(var i in a)
                Console.WriteLine(i);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Where(i=>i%2==0).Average());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Max());
            Console.ReadKey();
        }
    }
}
