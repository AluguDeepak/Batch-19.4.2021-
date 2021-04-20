using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //Abstract class 
    abstract class Shape
    {
        public abstract void Area(); //abstract function
        //public abstract void Area(double r);
        public void Type() //not abstract function/method
        {
            Console.WriteLine("I am a 2D Shape.");
        }
    }
    class Circle1:Shape
    {
        double r;
        public Circle1(double r)
        {
            this.r = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Circle: " + Math.PI * r * r);
        }
    }
    class Rectangle:Shape
    {
        int l, w;
        public Rectangle(int l,int w)
        {
            this.l = l;
            this.w = w;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectnalge: " + (l * w));
        }
    }
    class Demo4
    {
        static void Main()
        {
            Shape circle = new Circle1(12.3);
            Shape rectangle = new Rectangle(2, 4);
            circle.Area();
            rectangle.Area();
            Shape[] shapes = new Shape[2];
            shapes[0] = circle;
            shapes[1] = rectangle;
            foreach (Shape s in shapes)
            {
                s.Area();
                s.Type();
            }
        }
    }
}
