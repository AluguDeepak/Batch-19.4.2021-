using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.employee_id = 200;
            Console.WriteLine(employee.employee_id); //200
            Console.WriteLine(Employee.company_name);
            Employee employee1 = new Employee();
            Console.WriteLine(employee1.employee_id); //100
            Console.WriteLine(Employee.company_name);
            //Employee.company_name = "XYZ";
        }
    }
}
