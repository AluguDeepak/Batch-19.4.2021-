using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexer
{
    class Demo3
    {
        Dictionary<int, char> list = new Dictionary<int, char>()
        {
            {1000,'a' },
            {1002,'b' }
        };
        public char this[int i]
        {
            get { return list[i]; }
            set
            {
                list[i] = value;
            }
           
        }
        static void Main()
        {

            Demo3 obj = new Demo3();
            obj[1001] = 'b';
            obj[1002] = 'c';
            Console.WriteLine(obj[1002]);
            
        }
    }
}
