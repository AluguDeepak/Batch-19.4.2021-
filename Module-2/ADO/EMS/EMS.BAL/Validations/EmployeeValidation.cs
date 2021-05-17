using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EMS.BAL.Validations
{
    public static class EmployeeValidation
    {
        public static bool ValidateId(int EmpId)
        {

            if (Regex.IsMatch(EmpId.ToString(), @"^\d{4}$"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
