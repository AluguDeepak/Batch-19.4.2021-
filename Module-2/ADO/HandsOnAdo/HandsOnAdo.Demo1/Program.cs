using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnAdo.Demo1.Repositories;
namespace HandsOnAdo.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.GetEmployees();
        }
    }
}
