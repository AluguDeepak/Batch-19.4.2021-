using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("ID:{0} Name:{1} Age:{2}", Sid, Sname, Age);
        }
    }
    class WriteDemo1
    {
        public static void Write(string path)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                  new Student(){Sid=1,Sname="Rohan",Age=10},
                    new Student(){Sid=1,Sname="Rohan",Age=10},
                      new Student(){Sid=1,Sname="Rohan",Age=10},
                        new Student(){Sid=1,Sname="Rohan",Age=10},
                          new Student(){Sid=1,Sname="Rohan",Age=10},
                            new Student(){Sid=1,Sname="Rohan",Age=10},
                              new Student(){Sid=1,Sname="Rohan",Age=10},
                                new Student(){Sid=1,Sname="Rohan",Age=10},
                                  new Student(){Sid=1,Sname="Rohan",Age=10},
            };
            foreach(Student s in students)
            {
                File.AppendAllText(path, s+Environment.NewLine);
            }

        }
        static void Main()
        {
            Console.WriteLine("Enter File Path");
            string file_path = Console.ReadLine();
            Write(file_path);
        }
    }
}
