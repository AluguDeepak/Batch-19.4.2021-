using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace HandsOnReflection
{
    class Compute
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Greet()
        {
            Console.WriteLine("Hello World..");
        }
    }
    class Test_Compute
    {
        static void Main()
        {
            //Invoke Compute class Add() using reflection
            Type t = typeof(Compute);
            MethodInfo m = t.GetMethod("Greet");
            m.Invoke(null, null);
            Compute c = new Compute();
            t = c.GetType();
            MethodInfo m1 = t.GetMethod("Add");
            m1.Invoke(c, new object[] { 2, 3 });
           

        }
    }
    
}
