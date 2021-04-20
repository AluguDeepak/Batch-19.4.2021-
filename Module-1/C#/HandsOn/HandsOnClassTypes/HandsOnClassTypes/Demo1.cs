using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //static class allow only static members
    //static classes are not instatiated
    //static classes are not inherited
    public static class Calculate
    {
        private static double pi;
        static Calculate()
        {
            pi = 3.14;
        }
        public static double PI
        {
            get { return pi; }
        }
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static double Sqaure(double a)
        {
            return a * a;
        }
    }
    class Demo1
    {
        static void Main()
        {
            Calculate.Add(2, 3);
            Calculate.Sqaure(23);
        }
    }
}
