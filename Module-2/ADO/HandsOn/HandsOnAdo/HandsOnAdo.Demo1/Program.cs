using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnAdo.Demo1.Repositories;
using HandsOnAdo.Demo1.Entities;
namespace HandsOnAdo.Demo1
{
    class Program
    {
        public static void Menu()
        {
            try
            {
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Get Employee By ID");
                Console.WriteLine("3.Get All Employees");
                Console.WriteLine("4.Delete Employee");
                Console.WriteLine("5.Update Employee");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                EmployeeRepository repository = new EmployeeRepository();
                switch (choice)
                {
                    case 1:
                        {
                            Employee employee = new Employee()
                            {
                                Eid = 106,
                                Ename = "TIM",
                                Designation = "Programmer",
                                DeptId = "D002"
                            };
                            repository.AddEmployee(employee);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Id");
                            int eid = int.Parse(Console.ReadLine());
                            Employee employee = repository.GetEmployeeById(eid);
                            if (employee != null)
                            {
                                Console.WriteLine("Name:{0} Designatio:{1}", employee.Ename, employee.Designation);
                            }
                            else
                                Console.WriteLine("Invalid Employee Id");
                        }
                        break;
                    case 3:
                        {
                            repository.GetEmployees();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter Id");
                            int eid = int.Parse(Console.ReadLine());
                            repository.DeleteEmployee(eid);
                        }
                        break;
                    case 5:
                        {
                            Employee employee = new Employee()
                            {
                                Eid = 106,
                                Ename = "TIM",
                                Designation = "Sr Programmer",
                                DeptId = "D002"
                            };
                            repository.UpdateEmployee(employee.Eid,employee);
                        }
                        break;
                    case 6:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {

            do
            {
                Menu();
            } while (true);
        }
    }
}
