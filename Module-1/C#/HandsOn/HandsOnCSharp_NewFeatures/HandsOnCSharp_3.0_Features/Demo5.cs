using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp_3._0_Features
{
    class Demo5
    {
        static void Main()
        {
            var emp = new { Eid = 1, Ename = "Rohan", Age = 23 }; //anonymous objects.
            Console.WriteLine(emp.Eid + " " + emp.Ename + " " + emp.Age);
        }
    }
}
