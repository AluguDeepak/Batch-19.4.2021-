using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class SortedListDemo
    {
        static void Main()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1000, "ROhan");
            sortedList.Add(1234, "Karan");
            sortedList.Add(1002, "Suren");
            sortedList.Add(1004, "Peter");
            sortedList.Add(1090, 1234);
            foreach (DictionaryEntry d in sortedList)
                Console.WriteLine($"{d.Key}:{d.Value}");
        }
    }
}
