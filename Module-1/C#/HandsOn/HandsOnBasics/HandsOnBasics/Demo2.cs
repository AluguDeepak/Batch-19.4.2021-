using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBasics
{
    class Demo2
    {
        static void Main()
        {
            int[] a = new int[3];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            int[][] ja = new int[3][];
            ja[0] = new int[] { 2, 3, 4, 5 };
            ja[1] = new int[] { 4, 5 };
            ja[2] = new int[] { 6, 7, 8 };
            for(int i=0;i<ja.Length;i++)
            {
                for(int j=0;j<ja[i].Length;j++)
                {
                    ja[i][j] =Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<ja.Length;i++)
            {
                foreach(int k in ja[i])
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
          

        }
    }
}
