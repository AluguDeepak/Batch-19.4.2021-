using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class HashTableDemo
    {
        static void Main()
        {
            Hashtable hs = new Hashtable();
            hs.Add(1000, "Rohan");
            hs.Add('a', "Apple");
            hs.Add(1002, "Karan");
            hs.Add(1003, "Suresh");
            //access a value
            string s = hs[1000].ToString();
            foreach(object k in hs.Keys)
            {
                Console.WriteLine($"Key:{k} Value:{hs[k]}");
            }
            foreach(DictionaryEntry d in hs)
            {
                Console.WriteLine("{0} {1}", d.Key, d.Value);
            }

            hs.Remove('a'); //pass key value to remove the key-value pair.
        }
    }
}
