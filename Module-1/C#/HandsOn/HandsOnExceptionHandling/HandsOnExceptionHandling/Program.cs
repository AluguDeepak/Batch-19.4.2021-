using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 23, 34, 45, 56, 6 };
            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine("Error Handling Demo's");
            }
            catch(IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Error Occured");
            }
        }
    }
}
