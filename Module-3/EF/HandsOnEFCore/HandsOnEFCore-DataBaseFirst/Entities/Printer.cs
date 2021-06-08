using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnEFCore_DataBaseFirst.Entities
{
    public partial class Printer
    {
        public int PrinterId { get; set; }
        public string PrinterName { get; set; }
    }
}
