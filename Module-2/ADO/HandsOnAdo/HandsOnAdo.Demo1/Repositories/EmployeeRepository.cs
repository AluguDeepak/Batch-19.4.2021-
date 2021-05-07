using HandsOnAdo.Demo1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnAdo.Demo1.Repositories
{
    class EmployeeRepository : IEmployeeRepository
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        public Employee GetEmployeeById(int empId)
        {
            return null;
        }

        public void GetEmployees()
        {
            
            //initiate connection string
            try
            {
                connection = new SqlConnection("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=true");
                connection.Open(); //open connection to db
                command = new SqlCommand("Select * from Employee", connection);
                SqlDataReader reader=command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Console.WriteLine($"ID:{reader["Eid"]} Name:{reader["Ename"]} Designation:{reader["Desig"]}" +
                            $"DeptId {reader[3]}");
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();//close connection
            }
        }
    }
}
