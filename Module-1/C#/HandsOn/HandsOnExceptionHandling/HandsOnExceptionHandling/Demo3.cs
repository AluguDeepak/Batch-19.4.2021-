using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Demo3
    {
        static void Main()
        {
            Console.WriteLine("Enter a,b values");
            try
            {
                byte i = byte.Parse(Console.ReadLine());
                byte j = byte.Parse(Console.ReadLine());
                if(j==0)
                {
                    throw new DivideByZeroException("J value should not 0");
                }
                int result = i / j;
                Console.WriteLine("Divison: " + result);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (FormatException ex)
            {
                Console.WriteLine("enter only no's");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
