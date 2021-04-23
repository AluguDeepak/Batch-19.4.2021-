using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack<char> s1 = new Stack<char>();
            s1.Push('a');
            s1.Push('v');
            Stack stack = new Stack();
            stack.Push(20);
            stack.Push(23);
            stack.Push(34);
            stack.Push(45);
            stack.Push("Ram");
            int k = (int)stack.Peek();
            Console.WriteLine(k);
            stack.Pop(); //remove top value
            Console.WriteLine();
           
            foreach (int i in stack)
                Console.WriteLine(i);
        }
    }
}
