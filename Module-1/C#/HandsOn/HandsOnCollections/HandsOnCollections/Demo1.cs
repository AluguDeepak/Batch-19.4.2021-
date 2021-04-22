using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class Demo1
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Rohan");
            arrayList.Add(234.5);
            arrayList.Add(true);
            arrayList.Add(new DateTime(1990, 2, 23));
            int k = (int)arrayList[0];
            DateTime d = (DateTime)arrayList[4];
            foreach(object o in arrayList)
            {
                Console.WriteLine(o);
            }
        }
    }
}
