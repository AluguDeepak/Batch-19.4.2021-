using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //Sealed classes are not inherited.
    class A
    {

    }
    sealed class B:A
    {
        public void M()
        {

        }
    }
    class C
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABC";
            B obj = new B();
        }
    }
}
