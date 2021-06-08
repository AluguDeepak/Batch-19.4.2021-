using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
