using System;
using HandsOnEFCore_CodeFirst.Context;
using HandsOnEFCore_CodeFirst.Entities;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCore_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           using(EMSContext db=new EMSContext())
            {
                //Add new record
                //Employee employee = new Employee() { Name = "Karan", JoinDate = DateTime.Now, Salary = 12000, Designation = "Programmer" };
                //db.Employees.Add(employee);
                //db.SaveChanges();

                //Fetch Record by Id(Search by Primary key)

                //Employee employee = db.Employees.Find(10);
                //if (employee != null)
                //    Console.WriteLine("{0} {1}", employee.Name, employee.Designation);
                //else
                //    Console.WriteLine("Invalid Id");

                //Search Record using non-primary key

                //Employee employee = db.Employees.SingleOrDefault(i => i.Name == "Rajan");
                //if (employee != null)
                //    Console.WriteLine("{0} {1}", employee.Id, employee.Designation);
                //else
                //    Console.WriteLine("Invalid Name");

                //Return multiple records
                List<Employee> employees = db.Employees.Where(i => i.Designation == "Programmer").ToList();

                //Remove Recrod

                //Employee employee = db.Employees.Find(1);
                //db.Employees.Remove(employee);
                //db.SaveChanges();

                //Update Record

                Employee employee = db.Employees.Find(2);
                employee.Salary = 23000;
                db.Employees.Update(employee);
                db.SaveChanges();

            }
        }
    }
}
