using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingEF.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int Pid { get; set; }
        public DateTime? OrderDate { get; set; }
        [ForeignKey("Pid")]
        public Product Product { get; set; }
    }
}
