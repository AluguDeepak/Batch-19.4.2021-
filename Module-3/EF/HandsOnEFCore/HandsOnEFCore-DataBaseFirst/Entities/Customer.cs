using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Customer
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string City { get; set; }
    }
}
