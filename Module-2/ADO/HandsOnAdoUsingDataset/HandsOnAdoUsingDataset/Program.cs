using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnAdoUsingDataset
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection connection=new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=True"))
            {
                try
                {
                    string qry = "Select * from Employee";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, connection);
                    DataSet dataSet = new DataSet();
                    //fille dataset
                    dataAdapter.Fill(dataSet, "Emp");
                    //Read 1st row from dataset table
                    if (dataSet.Tables["Emp"].Rows.Count > 0)
                    {
                        //to access particular row in a dataset table.
                        //DataRow row = dataSet.Tables["Emp"].Rows[2];
                        //Console.WriteLine($"ID:{row["Eid"]} Name:{row["Ename"]}" +
                        //    $"Designation:{row["Desig"]} Salary:{row["Salary"]}");
                        foreach(DataRow row in dataSet.Tables["Emp"].Rows)
                        {
                            Console.WriteLine($"ID:{row["Eid"]} Name:{row["Ename"]}" +
                           $"Designation:{row["Desig"]} Salary:{row["Salary"]}");
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
