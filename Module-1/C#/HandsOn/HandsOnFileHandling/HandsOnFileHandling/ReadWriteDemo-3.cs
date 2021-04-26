using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnFileHandling
{
    class ReadWriteDemo_3
    {
        public static void Read(string file_path)
        {
            try
            {
                using (FileStream fileStream = new FileStream(file_path, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = new byte[fileStream.Length];
                    int length = (int)fileStream.Length;
                    fileStream.Read(data, 0, length);
                    string content = new UTF8Encoding().GetString(data);
                    Console.WriteLine(content);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }
        public static void Write(string file_path)
        {
            try
            {
                using (FileStream fileStream = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    string content = "Hello Good Morning Team..";
                    byte[] data = new UTF8Encoding().GetBytes(content);
                    int length = (int)fileStream.Length;
                    fileStream.Seek(1, SeekOrigin.End); //set the cursor position
                    fileStream.Write(data, 0, data.Length);
                   
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }

        }
        static void Main()
        {
            Console.WriteLine("Enter File Path");
            string file_path = Console.ReadLine();
            //Read(file_path);
            Write(file_path);
        }
    }
}
