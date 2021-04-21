using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class Demo4
    {
        static void Main()
        {
            Console.WriteLine("Enter a,b values");
            try
            {
                byte i = byte.Parse(Console.ReadLine());
                byte j = byte.Parse(Console.ReadLine());
                int result = i / j;
                Console.WriteLine("Divison: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("J value should not be 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("enter only no's");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("ExceptionHandling Demo's");
                //closing connections objects
                //closing file objects
            }
        }
    }
}
