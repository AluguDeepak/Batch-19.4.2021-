using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace EMS.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
       
        SqlCommand command = null;
        SqlDataAdapter dataAdapter = null;

        public bool AddEmployee(Employee employee)
        {
           try
            {
                command = new SqlCommand()
                {
                    CommandText = "AddEmployee",
                    CommandType = CommandType.StoredProcedure,
                    Connection=Connection.connection
                };
                command.Parameters.AddWithValue("@Ename", employee.EmployeeName);
                command.Parameters.AddWithValue("@Desig", employee.Designation);
                command.Parameters.AddWithValue("@Did", employee.DeptId);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.Parameters.AddWithValue("@JoinDate", employee.JoinDate);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        public bool DeleteEmployee(int Eid)
        {
            try
            {
                command = new SqlCommand()
                {
                    CommandText = "DeleteEmployee",
                    CommandType = CommandType.StoredProcedure,
                    Connection = Connection.connection
                };
                command.Parameters.AddWithValue("@Eid",Eid);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        public Employee GetEmployee(int EmpId)
        {
            try
            {
                Employee employee = null;
                command = new SqlCommand()
                {
                    CommandText = "GetEmployeeById",
                    CommandType = CommandType.StoredProcedure,
                    Connection = Connection.connection
                };
                command.Parameters.AddWithValue("@Eid", EmpId);
                dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable("Employee");
                dataAdapter.Fill(dataTable);
               if(dataTable.Rows.Count>0)
                {
                    DataRow dataRow = dataTable.Rows[0];
                    employee = new Employee()
                    {
                        EmployeeName = dataRow["Ename"].ToString(),
                        Designation = dataRow["Desig"].ToString(),
                        Salary=(int)dataRow["Salary"],
                        JoinDate=Convert.ToDateTime(dataRow["JoinDate"])
                    };
                }
                return employee;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                List<Employee> employees = null;
                command = new SqlCommand()
                {
                    CommandText = "GetEmployees",
                    CommandType = CommandType.StoredProcedure,
                    Connection = Connection.connection
                };
               
                dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet,"Employee");
                if (dataSet.Tables["Employee"].Rows.Count > 0)
                {
                    employees = new List<Employee>();
                    foreach (DataRow dataRow in dataSet.Tables["Employee"].Rows)
                    {
                        employees.Add(
                             new Employee()
                             {
                                 EmployeeID=(int)dataRow["Eid"],
                                 EmployeeName = dataRow["Ename"].ToString(),
                                 Designation = dataRow["Desig"].ToString(),
                                 Salary = (int)dataRow["Salary"],
                                 JoinDate = Convert.ToDateTime(dataRow["JoinDate"])
                             }
                            );
                    }
                   
                  
                }
                return employees;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                command = new SqlCommand()
                {
                    CommandText = "UpdateEmployee",
                    CommandType = CommandType.StoredProcedure,
                    Connection = Connection.connection
                };
                command.Parameters.AddWithValue("@Eid", employee.EmployeeID);
                command.Parameters.AddWithValue("@Desig", employee.Designation);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
