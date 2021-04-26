using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class ReadAndWriteUsingFile
    {
        public static void Read(string file_path)
        {
            //string[] lines = File.ReadAllLines(file_path);
            //foreach (string s in lines)
            //    Console.WriteLine(s);
            if (File.Exists(file_path))
            {
                string s = File.ReadAllText(file_path);
                Console.WriteLine(s);
            }
        }
        public static void Write(string file_path)
        {
            Console.WriteLine("Enter content.");
            string content = Console.ReadLine();
            // File.WriteAllText(file_path, content); //override the content.
            File.AppendAllText(file_path, content+Environment.NewLine);
        }
        public static void Write1(string file_path)
        {
            string[] flowers =
            {
                "Rose",
                "Lilly",
                "Jasmine",
                "Tulips"
            };
            File.AppendAllLines(file_path, flowers);
        }
        static void Main()
        {

            Console.WriteLine("Enter File Path");
            string file_path = Console.ReadLine();
            // Read(file_path);
            // Write(file_path);
            Write1(file_path);
        }
    }
}
