using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Student
    {
        public int? Sid { get; set; }
        public string Sname { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
