using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCConnectoAPIUsingJQuery.Models
{
    public class Product
    {
        public int Pid { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Pname { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Stock is Required")]
        public int Stock { get; set; }
    }
}
