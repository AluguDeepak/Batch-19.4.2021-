using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Emp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Desig { get; set; }
        public string Did { get; set; }
        public int? Salary { get; set; }
    }
}
