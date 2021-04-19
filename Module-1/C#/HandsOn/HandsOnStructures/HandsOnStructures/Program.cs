using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStructures
{
    struct Box
    {
        public int length;
        public int width;
        
        public Box(int l,int w)
        {
            this.length = l;
            this.width = w;
        }

      



        //public BoX() //not supported
        //{

        //}
        public static void Foo()
        {
            Console.WriteLine("Struct Demo");
        }
        public void Area()
        {
            Console.WriteLine("Area: " + length * width);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4);
            Box.Foo();
            box.Area();
            Box box1; //constuctor is not invoked
            box1.length = 34;
            box1.width = 10;
            box1.Area();
        }
    }
}
