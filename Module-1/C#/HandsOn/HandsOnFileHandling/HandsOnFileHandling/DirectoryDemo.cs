using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class DirectoryDemo
    {
        static void Main()
        {
           
            DirectoryInfo directory = new DirectoryInfo(@"D://");
            //directory.Create();
            //Get All Directories in a Drive
            DirectoryInfo [] directories=directory.GetDirectories();
            foreach (DirectoryInfo item in directories)
            {
                FileInfo [] files=item.GetFiles();
                Console.WriteLine("Files in {0} ", item.Name);

                foreach(FileInfo f in files)
                {
                    if(!f.IsReadOnly)
                    Console.WriteLine(f.Name);
                }
            }
        }
    }
}
