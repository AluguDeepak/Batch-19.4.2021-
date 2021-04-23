using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexer
{
    class Demo2
    {
        public List<int> list = new List<int>();
        public int this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
        public static void Main()
        {
            Demo2 obj = new Demo2();
            //Console.WriteLine(obj[0]);
            obj.list.Add(10);
            obj.list.Add(12);
            obj[3] = 40;
            obj[4] = 50;
        }
    }
}
