using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate int CubeDelegat(int i);
    class Demo2
    {
        public static int Cube(int i)
        {
            return i * i * i;
        }
        public static void Callback(CubeDelegat d,int i)
        {
            d(i);
        }
        static void Main()
        {
            CubeDelegat cubeDelegat11 = Cube;
            Console.WriteLine(cubeDelegat11(3));
            CubeDelegat cubeDelegat1 = delegate (int i) //Anonymous Method
              {
                  return i * i * i;
              };
            cubeDelegat1(10);
            cubeDelegat1(3);
            //lambda expression
            CubeDelegat cubeDelegat = (i) => i * i * i;
            Console.WriteLine(cubeDelegat(4));
            Console.WriteLine(cubeDelegat(6));
            Callback(cubeDelegat11, 7);
            Callback(Cube,10);
            Callback(delegate (int i)
            {
                return i * i * i;
            },3);
            Callback(i => i * i * i,8);
            Console.ReadKey();
        }
    }
}
