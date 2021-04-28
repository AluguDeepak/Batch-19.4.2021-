using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    //declaration of delegate
    public delegate void MyDelegate(string name);
    class Program
    {
        public static void Greet(string n)
        {
            Console.WriteLine("Hello " + n);
           // throw new DivideByZeroException();
        }
        public static void M(string n)
        {
            Console.WriteLine("Good Morning " + n);
        }
        public static void M1(string n)
        {
            Console.WriteLine("Good Morning " + n);
        }
        static void Main(string[] args)
        {
            //instantiate delegate
            //MyDelegate myDelegate = new MyDelegate(Greet); //passing method reference to delegate object.
            //MyDelegate myDelegate = Greet;
            MyDelegate myDelegate = null;
            myDelegate += Greet;
            //refer one more method using myDelegate
            myDelegate += M;
            myDelegate += M1;
            //invoking delete
            myDelegate("Sachin");
            //Remove method reference
            myDelegate -= M1;
            myDelegate("Rahul");
            Console.ReadKey();
        }
    }
}
