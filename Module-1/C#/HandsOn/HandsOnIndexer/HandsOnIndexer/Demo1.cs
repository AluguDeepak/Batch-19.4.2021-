using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexer
{
    class Demo1
    {
        public int k;
        //define indexer
        public int this[int i]
        {
            get { return k; }
            set { k = value; }
        }
        static void Main()
        {
            Demo1 obj = new Demo1();
            obj[0] = 10;
            Console.WriteLine(obj.k);
            Console.WriteLine(obj[0]);
        }
    }
}
