using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingEF.Entities;
namespace HandsOnAPIUsingEF.DBContext
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
