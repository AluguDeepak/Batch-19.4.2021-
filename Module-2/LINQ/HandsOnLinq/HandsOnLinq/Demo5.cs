using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace HandsOnLinq
{
    class Demo5
    {
        static void Main()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConn"].ConnectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Employee", connection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Employee");
                //Fileter the Data in Dataset using Linq
                DataTable dataTable = dataSet.Tables["Employee"];
                DataTable result = (from i in dataTable.AsEnumerable()
                                    where i.Field<int>("Salary")>15000
                                    orderby i.Field<int>("Salary") select i
                                    ).CopyToDataTable();
                foreach (DataRow r in result.Rows)
                    Console.WriteLine("{0} {1}", r[0], r[1]);

            }
        }
    }
}
