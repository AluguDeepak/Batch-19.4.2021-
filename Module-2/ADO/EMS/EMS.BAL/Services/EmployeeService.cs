using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.Repositories;
namespace EMS.BAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository employeeRepository = null;
        public EmployeeService()
        {
            employeeRepository = new EmployeeRepository();
        }
        public bool AddEmployee(Employee employee)
        {
            try
            {
                return employeeRepository.AddEmployee(employee);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteEmployee(int Eid)
        {
            return employeeRepository.DeleteEmployee(Eid);
        }

        public Employee GetEmployee(int EmpId)
        {
            return employeeRepository.GetEmployee(EmpId);
        }

        public List<Employee> GetEmployees()
        {
            return employeeRepository.GetEmployees();
        }

        public bool UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }
    }
}
