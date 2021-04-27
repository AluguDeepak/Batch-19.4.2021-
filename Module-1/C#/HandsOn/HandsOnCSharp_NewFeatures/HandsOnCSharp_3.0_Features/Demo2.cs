using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp_3._0_Features
{
    class Customer
    {
        //Automatic Properties
        public int CID { get; set; } = 100;
        public string Cname { get; set; }
        public string Address { get; set; }
    }

    class Demo2
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        static void Main()
        {
            Customer customer = new Customer() { CID = 1, Cname = "John" };
            
        }
    }
}
