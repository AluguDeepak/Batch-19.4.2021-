using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnEFCore_CodeFirst.Entities
{
    [Table("Employees")]
    class Employee
    {
        [Key] //set primarny key
        public int Id { get; set; }
        [MaxLength(50)]
        [Required] //to set not null
        public string Name { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? JoinDate { get; set; }
        public double Salary { get; set; }
        [MaxLength(50)]
        [Column(TypeName ="Char")]
        public string Designation { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
