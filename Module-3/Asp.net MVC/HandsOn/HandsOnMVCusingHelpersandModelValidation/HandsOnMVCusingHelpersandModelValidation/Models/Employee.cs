using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCusingHelpersandModelValidation.Models
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        public string Desig { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
