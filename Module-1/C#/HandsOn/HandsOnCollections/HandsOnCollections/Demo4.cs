using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnCollections
{
    class Demo4
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Sid = 100;
            s1.Sname = "Rohan";
            s1.Age = 10;
            s1.Std = "III";
            Student s2 = new Student() { Sid = 120, Sname = "Karan", Age = 9, Std = "II" }; //object initializer
            ArrayList arrayList = new ArrayList() { s1, s2,
            new Student() { Sid = 103, Sname = "Rashi", Age = 10, Std = "III" }};
            arrayList.Add(new Student() { Sid = 102, Sname = "Roshan", Age = 10, Std = "III" });

            Student s = arrayList[0] as Student;
            arrayList.Remove(s);
            s.Age = 11;
            arrayList.Insert(0,s);
           
            var List = (from Student i in arrayList orderby i.Sid select i).ToList();
            arrayList = new ArrayList(List);
            foreach (Student student in arrayList)
            {
                Console.WriteLine($"ID:{student.Sid},Naem:{student.Sname},Age:{student.Age},Class:{student.Std}");
            }

        }
    }
}
