using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public double Sqaure(double a)
        {
            return a * a;
        }
        //fetch even values from an array
        public int [] GetEvens(params int []a)
        {
            int[] b = new int[a.Length];
            int idx = 0;
            foreach(int i in a)
            {
                if(i%2==0)
                {
                    b[idx] = i;
                    idx++;
                }
            }
            return b;
        }
    }
}
