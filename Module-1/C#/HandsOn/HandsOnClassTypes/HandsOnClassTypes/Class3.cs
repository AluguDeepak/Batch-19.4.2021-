using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    partial class Employee
    {
        public void DeleteEmployee() { }
        public void UpdateEmployee() { }
        static void Main()
        {
            Employee employee = new Employee();
            employee.AddEmployee();
            employee.DeleteEmployee();
        }
    }
}
