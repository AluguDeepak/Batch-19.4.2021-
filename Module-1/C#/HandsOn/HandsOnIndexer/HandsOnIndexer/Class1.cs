using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIndexer
{
    class Class1
    {
        static void Main()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            list[1000] = "Ram";
            list[1001] = "Krishna";
            list.Add(1002, "Bheem");
        }
    }
}
