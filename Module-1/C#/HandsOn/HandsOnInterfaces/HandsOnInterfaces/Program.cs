using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService(); //access all the members of class
            service.GetEmployees();
            service.GetEmployeeByName("Rohan");
            IEmployeeService service1 = new EmployeeService(); //access only interface members
            service1.GetEmployees();
           
        }
    }
}
