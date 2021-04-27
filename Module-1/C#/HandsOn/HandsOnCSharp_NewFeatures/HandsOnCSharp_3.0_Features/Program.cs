using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp_3._0_Features
{
    class Employee
    { }
    class Program
    {

        static void Main(string[] args)
        {
            int a;
            //implicitly typed local varibles
            var v = 10;
            int k = v;
            var v1 = "Abcd";
            var v2 = new Employee();
            Employee e3 = v2;
            object o1 = 10;
            k = (int)o1;
            object o2 = "ABCD";
            object o3 = new Employee();
            Employee e1 = o3 as Employee;
           
           

        }
    }
}
