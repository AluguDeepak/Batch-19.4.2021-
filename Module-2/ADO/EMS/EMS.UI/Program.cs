using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.BAL.Services;
using EMS.BAL.Validations;
using EMS.Entities;
namespace EMS.UI
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1.Employee");
            Console.WriteLine("2.Dept");
            Console.WriteLine("Enter your choice");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    {
                        EmployeeMenu();
                    }
                    break;
                case 2:
                    {
                        DeptMenu();
                    }
                    break;
            }
           void EmployeeMenu()
            {
                Console.WriteLine("1.AddEmployee");
                Console.WriteLine("2.GetEmployees");
                Console.WriteLine("3.GetEmployeeById");
                Console.WriteLine("4.DeleteEmployee");
                Console.WriteLine("5.UpDateEmployee");
                Console.WriteLine("Enter your Option");
                int option = int.Parse(Console.ReadLine());
                EmployeeService employeeService = new EmployeeService();
                switch(option)
                {
                    case 1:
                        {
                            Employee employee = new Employee();
                            Console.WriteLine("Entere ID");
                            employee.EmployeeID = int.Parse(Console.ReadLine());
                            if(!EmployeeValidation.ValidateId(employee.EmployeeID))
                            {
                                Console.WriteLine("Employee ID should be 4 degit no");
                                break;
                            }
                            Console.WriteLine("Enter Name");
                            employee.EmployeeName = Console.ReadLine();
                            Console.WriteLine("Enter Designation");
                            employee.Designation = Console.ReadLine();
                            Console.WriteLine("Entrer DeptId");
                            employee.DeptId = Console.ReadLine();
                            Console.WriteLine("Enter Salary");
                            employee.Salary = double.Parse(Console.ReadLine());
                            employee.JoinDate = DateTime.Now;
                            employeeService.AddEmployee(employee);

                        }
                        break;
                    case 2:
                        {
                            List<Employee> employees = employeeService.GetEmployees();
                            foreach(Employee employee in employees)
                            {
                                Console.WriteLine("ID:{0} Name: {1} Designation:{2} Salary:{3}", employee.EmployeeID,
                                    employee.EmployeeName, employee.Designation, employee.Salary);
                            }
                        }
                        break;
                }
            }
            void DeptMenu()
            {

            }
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Menu();
                } while (true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
