using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBasics
{
    class Demo1
    {
        static void Main()
        {
            string s = "Hello World";
            foreach(char ch in s)
            {
                Console.WriteLine("Char Value {0} and ASCII {1}",ch,Convert.ToByte(ch));
            }
            int[] a = { 12, 34, 45, 56, 67, 78, 89 };
            int sum = 0;
            foreach(int k in a)
            {
                sum = sum + k;
            }

            string[] names = { "Rohan", "Rajan", "Suren", "Monica" };
            foreach(string s1 in names)
            {
                Console.Write(s1+" ");
            }
        }
    }
}
