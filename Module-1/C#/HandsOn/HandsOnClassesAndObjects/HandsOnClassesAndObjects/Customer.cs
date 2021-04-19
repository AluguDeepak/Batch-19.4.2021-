using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    class Customer
    {
        private int customerId;
        private string customerName;
        public static string city;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public void Details(Customer customer)
        {
            Console.WriteLine($"ID:{customer.customerId} Name:{customer.customerName} City:{Customer.city}");
        }
    }
    class Test_Customer
    {
        static void Main()
        {
            Customer.city = "Banglore";
            Customer[] customers = new Customer[4];
            customers[0] = new Customer();
            customers[0].CustomerId = 100;
            customers[0].CustomerName = "Ganga";
          
            customers[1] = new Customer() { CustomerId = 101, CustomerName = "Charan" };
            customers[2] = new Customer() { CustomerId = 102, CustomerName = "Peter" };
            customers[3] = new Customer();
            //customers[0].Details(customers[0]);
            //customers[1].Details(customers[1]);
            //customers[2].Details(customers[2]);
            foreach (Customer c in customers)
            {
                c.Details(c);
            }

        }
    }
}
