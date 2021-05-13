using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HandsOnAdoUsingDataset.Entity;
namespace HandsOnAdoUsingDataset.Repositories
{
    class ProductRepositories
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BatchDBConn"].ConnectionString);
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlCommandBuilder commandBuilder = null;
       public ProductRepositories()
        {
            da = new SqlDataAdapter("Select * from Product", con);
            commandBuilder = new SqlCommandBuilder(da); //it generates dml queries for every chane of dataset
            ds = new DataSet();
            da.Fill(ds, "Product");
            //set primary key to dataset table
            ds.Tables["Product"].PrimaryKey = new DataColumn[] { ds.Tables["Product"].Columns[0] };
        }
        public List<Product> GetProducts()
        {
            List<Product> products = null;
            if(ds.Tables["Product"].Rows.Count>0)
            {
                products = new List<Product>();
                foreach(DataRow row in ds.Tables["Product"].Rows)
                {
                    products.Add(new Product()
                    {
                        Pid = (int)row["Pid"],
                        Pname = row["Pname"].ToString(),
                        Price=(int)row["Price"],
                        Stock=(int)row["Stock"]

                    });
                    
                }
               
            }
            return products;
        }
        public Product GetProduct(int Pid)
        {
            DataRow row = ds.Tables["Product"].Rows.Find(Pid); //Find() search record in datatable using PK column value.
            Product product = null;
            if(row!=null)
            {
                product = new Product()
                {
                    Pid = (int)row["Pid"],
                    Pname = row["Pname"].ToString(),
                    Price = (int)row["Price"],
                    Stock = (int)row["Stock"]

                };
            }
            return product;
        }
        public bool AddProduct(Product product)
        {
            try
            {
                //Adding row to Dataset
                DataRow row = ds.Tables["Product"].NewRow();
                row["Pid"] = product.Pid;
                row["Pname"] = product.Pname;
                row["Price"] = product.Price;
                row["Stock"] = product.Stock;
                //Add new row to the Dataset
                ds.Tables["Product"].Rows.Add(row);
                da.Update(ds, "Product"); //Add Dataset tables changes to backend sql server table.
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public bool DeleteProduct(int Pid)
        {
            try
            {
                ds.Tables["Product"].Rows.Find(Pid).Delete(); //row deleted
                da.Update(ds, "Product");
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateProduct(Product product)
        {
            try
            {
                ds.Tables["Product"].Rows.Find(product.Pid)["Price"] = product.Price;
                ds.Tables["Product"].Rows.Find(product.Pid)["Stock"] = product.Stock;
                da.Update(ds, "Product");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    class Test_Repository
    {
        static void Main()
        {
            try
            {
               Product product = new Product() { Pid = 2, Pname = "Mouse", Price = 800, Stock = 10 };
                ProductRepositories repositories = new ProductRepositories();
                //repositories.AddProduct(product);
                // repositories.DeleteProduct(3);
                repositories.UpdateProduct(product);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
