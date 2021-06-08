using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Dept
    {
        public Dept()
        {
            Employees = new HashSet<Employee>();
        }

        public string Did { get; set; }
        public string Dname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
