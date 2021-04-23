using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class QueueDemo
    {
        static void Main()
        {
            Queue<int> queue1 = new Queue<int>();
            Queue queue = new Queue();
            queue.Enqueue("Rose");
            queue.Enqueue("Daffodil");
            queue.Enqueue("Sunflower");
            queue.Enqueue("Lilly");
            string flower = queue.Peek().ToString(); //return first item
            queue.Dequeue(); //removes first item.

            foreach (string s in queue)
                Console.WriteLine(s);
        }
    }
}
