using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.Repositories;
namespace EMS.BAL.Services
{
    class DeptService : IDeptService
    {
        DeptRepository deptRepository = null;
        public DeptService()
        {
            deptRepository = new DeptRepository();
        }
        public bool AddDept(Dept dept)
        {
            try
            {
                return deptRepository.AddDept(dept);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
