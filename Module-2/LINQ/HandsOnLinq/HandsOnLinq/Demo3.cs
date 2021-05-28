using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
    }

    class Demo3
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Eid=1,Ename="Rohan"},
                new Employee(){Eid=2,Ename="Karan"},
                new Employee(){Eid=3,Ename="Jeson"},
                new Employee(){Eid=4,Ename="Suman"},
                new Employee(){Eid=5,Ename="Raman"},
                new Employee(){Eid=6,Ename="Charan"},
            };
            Employee e1 = employees.First();
            e1 = employees.Where(i => i.Ename.StartsWith("R")).First();
            // e1 = employees.Where(i => i.Ename.StartsWith("R")).Last();
            //FirstOrDefault() return null when there is no items in sequence
            e1 = employees.Where(i => i.Ename.StartsWith("T")).FirstOrDefault();
            if(e1!=null)
            Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            //LastOrDefault() return null when there is no items in sequence
            e1 = employees.Where(i => i.Ename.StartsWith("T")).LastOrDefault();
            if (e1 != null)
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            e1 = employees.Where(i => i.Eid == 1).Single();//when sequence contains only one element
             e1 = employees.Single(i => i.Eid>10); //throws exception when sequence return multile elemens or no elementes
            e1 = employees.SingleOrDefault(i => i.Eid == 1);
            if (e1 != null)
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            else
                Console.WriteLine("Invalid Id");
            //ToList() used when sequence contain more than one element.
            List<Employee> employees1 = employees.Where(i => i.Ename.StartsWith("R")).ToList();
            e1 = employees.Where(i => i.Eid > 3).ElementAt(1); //returns element at 2nd index
            e1 = employees.Where(i => i.Eid > 3).ElementAtOrDefault(10);
            if(e1!=null)
            {
                Console.WriteLine("{0} {1}", e1.Eid, e1.Ename);
            }
        }
    }
}
