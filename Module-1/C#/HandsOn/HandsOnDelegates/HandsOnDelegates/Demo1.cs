using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void Delegate1();
    class Demo1
    {
        public void M1()
        {
            Console.WriteLine("Do something");
        }
        public void M2(Delegate1 del1)
        {
            del1(); //calling delegate
        }
        static void Main()
        {
            Demo1 obj = new Demo1();
            Delegate1 d1 = new Delegate1(obj.M1);
            obj.M2(d1);
            obj.M2(obj.M1);
            Console.ReadKey();
        }
    }
}
