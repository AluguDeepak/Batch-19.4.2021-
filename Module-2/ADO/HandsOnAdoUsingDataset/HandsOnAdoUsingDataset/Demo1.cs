using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnAdoUsingDataset
{
    class Demo1
    {
        static void Main()
        {
            SqlDataAdapter dataAdapter = null;
            using (SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=True"))
            {
                try
                {
                    string qry = "Select * from Employee";
                   dataAdapter = new SqlDataAdapter(qry, connection);
                    DataSet dataSet = new DataSet();
                    //fille dataset
                    dataAdapter.Fill(dataSet, "Emp");
                    //Read 1st row from dataset table
                    if (dataSet.Tables["Emp"].Rows.Count > 0)
                    {
                       
                        foreach (DataRow row in dataSet.Tables["Emp"].Rows)
                        {
                            Console.WriteLine($"ID:{row["Eid"]} Name:{row["Ename"]}" +
                           $"Designation:{row["Desig"]} Salary:{row["Salary"]}");
                        }
                    }
                    dataAdapter = new SqlDataAdapter("Select * from Dept", connection);
                    dataAdapter.Fill(dataSet, "Dept");
                    Console.WriteLine("\n");
                    foreach (DataRow row in dataSet.Tables["Dept"].Rows)
                    {
                        Console.WriteLine($"ID:{row["Did"]} Name:{row["Dname"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
