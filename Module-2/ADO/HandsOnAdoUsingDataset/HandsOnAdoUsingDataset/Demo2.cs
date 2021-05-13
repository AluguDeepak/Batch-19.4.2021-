using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HandsOnAdoUsingDataset
{
    class Demo2
    {
        static void Main()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=True"))
            {
                try
                {
                    SqlCommand command = new SqlCommand()
                    {
                        CommandText = "GetProductById",
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@Pid", 1);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable("Product");
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        Console.WriteLine($"Name:{row["Pname"]} Price:{row["Price"]}");
                    }
                    else
                    {
                        Console.WriteLine("Product with Given ID not exist");
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
