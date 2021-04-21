using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    //User-defined exceptions
    public class TicketExcption:ApplicationException
    {
        public TicketExcption(string msg):base(msg)
        {

        }
        // public override string Message => "Transaction Failed:\n Reason:User allow only 3 tickets.";
        public override string Message => base.Message;
    }
    class Demo5
    {
        public static void BookTicket(int tickets)
        {
            try
            {
                if (tickets > 4)
                {
                    //throw new TicketExcption();
                    throw new TicketExcption("Enter only 3 tickets..");
                }
                else
                    Console.WriteLine("Transaction Successfull.");
            }
            catch(TicketExcption ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter No of Tickets");
                int ticket = int.Parse(Console.ReadLine());
                BookTicket(ticket);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
