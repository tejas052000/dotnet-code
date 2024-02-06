using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_directory_demo
{
    class FileStreamEg
    {
        static void Main()
        {
            int i;
            FileStream fs1 = new FileStream("C:\\Users\\SQUAD\\Desktop\\vandana\\FileEx.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream("C:\\Users\\SQUAD\\Desktop\\vandana\\FileEx2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // copy file1 to file2
            try
            {
                do
                {
                    i = fs1.ReadByte();
                    if (i != -1)
                        fs2.WriteByte((byte)i);//typecasting
                } while (i != -1);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            fs1.Close();
            fs2.Close();    



            //Read Data from the file

            string path = @"C:\Users\SQUAD\Desktop\vandana\FileEx2.txt";
            using (FileStream fs3 = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs3.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));

                }
                Console.Read();
            }
        }   
    }
}
