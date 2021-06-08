using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Employee1
    {
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string City { get; set; }
    }
}
