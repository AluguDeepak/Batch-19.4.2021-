using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnEFCore_DataBaseFirst.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCore_DataBaseFirst
{
    class StoredProcedures_Demo
    {

        static void Main()
        {
            Batch2DBContext dBContext = new Batch2DBContext();
            List<Product> products = dBContext.Products.FromSqlRaw("GetProducts").ToList();
            //foreach(var item in products)
            //{
            //    Console.WriteLine("{0} {1}",item.Pid,item.Pname);
            //}
            var product = dBContext.Products.FromSqlRaw("GetProductById @Pid", new SqlParameter("@Pid", 1));
            foreach (var item in product)
            {
                Console.WriteLine("{0} {1}", item.Pid, item.Pname);
            }
            //Add Product
            dBContext.Database.ExecuteSqlRaw("AddProduct @p0,@p1,@p2,@p3",
                parameters: new object[] { 111, "CCCC", 340, 120 });
        }
    }
}
