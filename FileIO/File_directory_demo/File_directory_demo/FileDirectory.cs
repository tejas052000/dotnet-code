using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_directory_demo
{
    class FileDirectory
    {
        public static void Main()
        {
            FileInfo aFile = new FileInfo("C:\\Users\\SQUAD\\Desktop\\vandana\\FileEx.txt");
            if (aFile.Exists)
            {
                Console.WriteLine("File Name: " + aFile.Name);
                Console.WriteLine("File Extention: " + aFile.Extension);
                Console.WriteLine("File's Full Name: " + aFile.FullName);
                Console.WriteLine("Parent Directory: " + aFile.DirectoryName);
                Console.WriteLine("File Size: " + aFile.Length.ToString() + " bytes");
                Console.WriteLine("File Attributes: " + aFile.Attributes.ToString());
               
            }
            else
            {
                aFile.Create();
                Console.WriteLine("File created");
            }
            Console.Read();
        }

    }
}
