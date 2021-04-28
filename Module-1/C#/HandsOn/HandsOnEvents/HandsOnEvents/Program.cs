using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEvents
{
    class Publisher
    {
        public delegate void EventDelegate();
        public delegate void EventDelegate1(string name);
        //event declaration
        public event EventDelegate myevent;
        public event EventDelegate1 myevent1;
        public void FireEvent()
        {
            if(myevent!=null)
            {
                myevent(); //fire event
                myevent1("Sachin");
            }
        }
    }
    class Subscriber
    {
        public void Task()
        {
            Console.WriteLine("Task is Running..");
        }
        public void Task1()
        {
            Console.WriteLine("Task is Running..");
        }
        public  void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            //Subscribing Methods to event
            publisher.myevent += subscriber.Task;
            publisher.myevent += subscriber.Task1;
            //publisher.myevent += subscriber.Greet;
            publisher.myevent1 += subscriber.Greet;
            publisher.FireEvent(); //calling this method to fire the event.
            Console.ReadKey();
          
        }
    }
}
