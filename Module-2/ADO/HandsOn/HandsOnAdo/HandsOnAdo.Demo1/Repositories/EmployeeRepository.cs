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
        SqlConnection connection = new SqlConnection("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=true");
        SqlCommand command = null;
        public Employee GetEmployeeById(int empId)
        {
          try
            {
               // connection = new SqlConnection("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=true");
                connection.Open(); //open connection to db
                command = new SqlCommand("Select * from Employee where Eid=@Eid", connection);
                //passing values to @Eid Parameter
                command.Parameters.AddWithValue("@Eid", empId);
                SqlDataReader reader=command.ExecuteReader();
                Employee employee = null;
                if(reader.HasRows)
                {
                    reader.Read();
                    employee = new Employee();
                    employee.Ename = reader["Ename"].ToString();
                    employee.Designation = reader["Desig"].ToString();
                    employee.DeptId = reader["DId"].ToString();
                }
                return employee;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void GetEmployees()
        {
            
            //initiate connection string
            try
            {
                //connection = new SqlConnection("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Batch2DB;Integrated Security=true");
                if(connection.State==System.Data.ConnectionState.Closed) //checks weather connection is closed or not
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
        public void AddEmployee(Employee employee)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO EMPLOYEE VALUES(@EID,@ENAME,@DESIG,@DID)", connection);
                command.Parameters.AddWithValue("@EID", employee.Eid);
                command.Parameters.AddWithValue("@ENAME", employee.Ename);
                command.Parameters.AddWithValue("@DESIG", employee.Designation);
                SqlParameter parameter = new SqlParameter("@DID",employee.DeptId);
                command.Parameters.Add(parameter);//add paramter object to the parameter collection.
                command.ExecuteNonQuery(); //to execute dml queries wich are passing in the command class
                Console.WriteLine("Record is Added");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void DeleteEmployee(int empId)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("DELETE FROM EMPLOYEE WHERE EID=@EID", connection);
                command.Parameters.AddWithValue("@EID", empId);
                command.ExecuteNonQuery(); //to execute dml queries wich are passing in the command class
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateEmployee(int empId, Employee employee)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("UPDATE EMPLOYEE SET DESIG=@DESIG,DID=@DID WHERE EID=@EID", connection);
                command.Parameters.AddWithValue("@EID", empId);
                command.Parameters.AddWithValue("@DESIG", employee.Designation);
                SqlParameter parameter = new SqlParameter("@DID", employee.DeptId);
                command.Parameters.Add(parameter);//add paramter object to the parameter collection.
                command.ExecuteNonQuery(); //to execute dml queries wich are passing in the command class
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
