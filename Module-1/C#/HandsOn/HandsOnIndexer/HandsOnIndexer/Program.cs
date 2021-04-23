using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 34, 45, 56 };
            Console.WriteLine(a[0]); //12
            List<int> list = new List<int>() { 12, 23, 3, 45, 56 };
            Console.WriteLine(list[2]);
            string s = "Hello World.";
            Console.WriteLine(s[4]);
        }
    }
}
