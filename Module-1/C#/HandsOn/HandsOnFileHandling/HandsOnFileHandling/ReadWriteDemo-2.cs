using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class ReadWriteDemo_2
    {
        public static void Read(string file_path)
        {
            using(StreamReader reader=new StreamReader(file_path))
            {
                string content = reader.ReadToEnd(); //reads all lines in the given text file
                Console.WriteLine(content);
            }
        }
        public static void Write(string file_path)
        {
            using(StreamWriter writer=new StreamWriter(file_path))
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
                    writer.WriteLine(s); //WriteLine writes text to the given file.
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter File Path");
            string file_path = Console.ReadLine();
            // Read(file_path);
            Write(file_path);
        }
    }
}
