using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Entities;
namespace EMS.DAL.Repositories
{
    public interface IDeptRepository
    {
        bool AddDept(Dept dept);
    }
}
