using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCore_CodeFirst.Context
{
    class EMSContext:DbContext
    {
        //Manage ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set Connectionstring
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=EMS;User ID=sa;Password=pass@word1");
        }
        //Entity Set
        public DbSet<Employee> Employees { get; set; }
    }
}
