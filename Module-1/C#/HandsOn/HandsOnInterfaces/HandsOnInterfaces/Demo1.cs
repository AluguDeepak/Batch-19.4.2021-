using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
   interface IShape
    {
        void Area();
    }
    class Circle:IShape
    {
        public void Area() { }
    }
    class Rectangle:IShape
    {
        public void Area() { }
    }
    class Trinagle:IShape
    {
        public void Area() { }
    }
    class Demo1
    {
        static void Main()
        {

        }
    }
}
