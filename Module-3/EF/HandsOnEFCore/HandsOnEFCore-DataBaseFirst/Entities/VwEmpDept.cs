using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class VwEmpDept
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Did { get; set; }
        public string Dname { get; set; }
    }
}
