using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class Program
    {
        public static void GetFileInfo(string file_path)
        {
            try
            {
                FileInfo info = new FileInfo(file_path);
                if (info.Exists)
                {
                    Console.WriteLine("FileName: " + info.Name);
                    Console.WriteLine("FilePath: " + info.FullName);
                    Console.WriteLine("Extension: " + info.Extension);
                    Console.WriteLine("CreationDate: " + info.CreationTime);
                    Console.WriteLine("Directory: " + info.DirectoryName);
                    Console.WriteLine("Size:{0}KB " ,info.Length);
                }
                else
                    Console.WriteLine("File not exist");
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Path");
            string file_path = Console.ReadLine();
            GetFileInfo(file_path);
        }
    }
}
