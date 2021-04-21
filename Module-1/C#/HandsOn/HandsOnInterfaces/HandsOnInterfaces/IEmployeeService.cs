using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    abstract class EmployeeInfo
    {
        public void Details()
        {

        }
    }
    interface IEmployeeService
    {
        bool AddEmployee(Employee employee);
        Employee GetEmployee(int Eid);
         Employee[] GetEmployees();
        bool DeleteEmployee(int Eid);

    }
    class EmployeeService:EmployeeInfo, IEmployeeService
    {
        Employee[] employees = new Employee[10];
        public bool AddEmployee(Employee employee)
        {
            employees[0] = employee;
            return true;
        }
        public Employee GetEmployee(int Eid)
        {
            Employee employee = null;
            foreach(Employee e in employees)
            {
                if (e.Eid == Eid)
                    employee = e;
              
            }
            return employee;
        }
        public Employee[]GetEmployees()
        {
            return employees;
        }
        public bool DeleteEmployee(int Eid)
        {
            return true;
        }
        public Employee GetEmployeeByName(string name)
        {
            return new Employee();
        }
    }
}
