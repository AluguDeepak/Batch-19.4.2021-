using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Currency
    {
        public static double DTR(double dollers)
        {
            double result = dollers * 76.8;
            return result;
        }
        public static double RTD(double rupees)
        {
            double result = rupees/76.8;
            return result;
        }
    }
}
