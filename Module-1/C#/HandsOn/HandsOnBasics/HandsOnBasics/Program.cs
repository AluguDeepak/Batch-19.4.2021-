using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MathLibrary;
using TempLib;
namespace HandsOnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World..");
            Calculate calculate = new Calculate();
            int result = calculate.Add(2, 3);
            Console.WriteLine(result);
            double output = Currency.DTR(1000);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
