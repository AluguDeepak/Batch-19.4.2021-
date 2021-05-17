using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EMS.DAL.Repositories
{
    public class DeptRepository : IDeptRepository
    {
        SqlCommand command = null;
        public bool AddDept(Dept dept)
        {
            try
            {
                command = new SqlCommand("INSERT INTO DEPT VALUES(@Did,@Dname", Connection.connection);
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
    }
}
