using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    class Student
    {
        private int studentId;
        private string studentName;
        public Student() //default constructor
        {

        }
        public Student(int studentId, string studentName) //parameterized constructor
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }
        public Student(int sId)
        {
            this.studentId = sId;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
    }
    class Test_Student
    {
        static void Main()
        {
            
            Student student = new Student(100, "Rohan");
            Console.WriteLine("Id={0} Name={1}", student.StudentId, student.StudentName);
            Student student1 = new Student(101, "Karan");
            Console.WriteLine("Id={0} Name={1}", student1.StudentId, student1.StudentName);
            Student student2 = new Student();
            student2.StudentId = 102;
            student2.StudentName = "Hari";
            Console.WriteLine("Id={0} Name={1}", student2.StudentId, student2.StudentName);
        }
    }

}
