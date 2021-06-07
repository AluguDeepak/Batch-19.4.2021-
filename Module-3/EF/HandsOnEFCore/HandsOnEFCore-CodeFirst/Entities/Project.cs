using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCore_CodeFirst.Entities
{
    [Table("Projects")]
    class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable the identiy
        public int ProjectId { get; set; }
        [Required]
        [MaxLength(20)]
        public string ProjectName { get; set; }
        public IList<Employee> Employees { get; set; } //Project can have many employees

    }
}
