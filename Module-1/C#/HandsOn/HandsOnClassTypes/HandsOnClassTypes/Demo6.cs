using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class Round<T,K>
    {
        public T i;
        public K j;
    }
    class Demo6
    {
        static void Main()
        {
            Round<int, double> round = new Round<int, double>();
            round.i = 10;
            round.j = 2.34;
            Round<string, int> round1 = new Round<string, int>();
        }
    }
}
