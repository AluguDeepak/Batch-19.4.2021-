using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp_3._0_Features
{
    class Demo6
    {
        //Extension Methods are using to extending the features of existing types(int,string,class etc)
        static void Main()
        {
            int i = 10;
            Console.WriteLine(i.Sqaure());
            string s = "ABCD";
            s = s.ToUpper();
            string s1 = null;
           
            
        }


    }
   static class Extensions
    {
        public static int Sqaure(this int i)
        {
            return i * i;
        }
        public static string Reverse(this string s)
        {
            char []ch = s.ToCharArray();
            Array.Reverse(ch);
            return new String(ch);
        }
    }
}
