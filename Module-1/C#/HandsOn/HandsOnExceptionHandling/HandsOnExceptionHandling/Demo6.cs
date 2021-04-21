using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Demo6
    {
        public static void Div(byte a ,byte b)
        {
            try
            {
                int c = a / b;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter a,b values");
            try
            {
                byte a = byte.Parse(Console.ReadLine());
                byte b = byte.Parse(Console.ReadLine());
                Div(a, b);
                 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
