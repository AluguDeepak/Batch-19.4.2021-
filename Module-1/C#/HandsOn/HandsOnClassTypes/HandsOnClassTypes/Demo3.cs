using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    static class Circle
    {
        public static double r;
        private static double PI;
        static Circle()
        {
            PI = 3.14;
        }
        public static void Area()
        {
            Console.WriteLine("Area of Circle: " + PI * r * r);
        }

    }
    class Demo3
    {
        static void Main()
        {
            Circle.r = 23.4;
            Circle.Area();
        }
    }
}
