using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class ListDemo1
    {
        static void Main()
        {
            List<int> list1 = new List<int>() { 12, 34, 45, 56, 78 };
            list1.Add(39);
            list1.Insert(2, 100);
            List<string> list2 = new List<string>() { "Ram", "Raj", "Charan" };
            int k = list1[2];
            string s = list2[3];
            Student s1 = new Student() { Std = "II", Sid = 5, Sname = "Monica", Age = 10 };
            List<Student> students = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10,Std="III"},
                new Student(){Sid=2,Sname="Charan",Age=10,Std="III"},
                new Student(){Sid=3,Sname="Suren",Age=10,Std="III"},
                new Student(){Sid=4,Sname="Suresh",Age=10,Std="III"},
            };
            students.Add(s1);
        }
    }
}
