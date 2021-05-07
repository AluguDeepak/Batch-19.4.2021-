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
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            //repository.GetEmployees();
            Console.WriteLine("Enter Id");
            int eid = int.Parse(Console.ReadLine());
           Employee employee =repository.GetEmployeeById(eid);
            if (employee != null)
            {
                Console.WriteLine("Name:{0} Designatio:{1}", employee.Ename, employee.Designation);
            }
            else
                Console.WriteLine("Invalid Employee Id");
        }
    }
}
