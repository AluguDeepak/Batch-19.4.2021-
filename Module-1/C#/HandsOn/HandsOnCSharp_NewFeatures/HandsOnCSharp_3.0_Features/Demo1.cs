using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp_3._0_Features
{
    class Student
    {
        public int sId;
        public string sName;
        public int age;
    }

    class Demo1
    {
        static void Main()
        {
            Student student = new Student();
            student.sId = 10;
            student.sName = "Rohan";
            student.age = 9;
            Student student1 = new Student() { sId = 1, sName = "Charan", age = 10 };//object initiazer
            List<Student> list1 = new List<Student>() { student, student1 };
            List<Student> list2 = new List<Student>() //collection initializer
            {
                new Student() { sId = 1, sName = "Charan", age = 10 },
                new Student() { sId = 1, sName = "Charan", age = 10 },
                new Student() { sId = 1, sName = "Charan", age = 10 },
                new Student() { sId = 1, sName = "Charan", age = 10 },
            };
        }
    }
}
