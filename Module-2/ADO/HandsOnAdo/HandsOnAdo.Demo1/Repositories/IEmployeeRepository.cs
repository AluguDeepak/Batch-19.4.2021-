using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnAdo.Demo1.Entities;
namespace HandsOnAdo.Demo1.Repositories
{
    public interface IEmployeeRepository
    {
        void GetEmployees();
        Employee GetEmployeeById(int empId);
    }
}
