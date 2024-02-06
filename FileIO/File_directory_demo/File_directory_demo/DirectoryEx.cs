using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_directory_demo
{
    class DirectoryEx
    {
        public static void Main()
        {
            Console.WriteLine("Directory 'C:\\Users\\SQUAD\\Desktop\\vandana' exists"
            + Directory.Exists("C:\\Users\\SQUAD\\Desktop\\vandana2").ToString());

            Console.WriteLine("Creating Directory 'C:\\Users\\SQUAD\\Desktop\\vandana': "
            + Directory.CreateDirectory("C:\\Users\\SQUAD\\Desktop\\vandana2").ToString());

            Console.WriteLine("Directory 'C:\\Users\\SQUAD\\Desktop\\vandana' exists: "
            + Directory.Exists("C:\\Users\\SQUAD\\Desktop\\vandana2").ToString());

            Console.WriteLine("Parent Directory of 'C:\\Users\\SQUAD\\Desktop\\vandana' is: "
            + Directory.GetParent("C:\\Users\\SQUAD\\Desktop\\vandana2").ToString());

            Console.WriteLine("Deleting Directory 'C:\\Users\\SQUAD\\Desktop\\vandana'... ");
            Directory.Delete("C:\\Users\\SQUAD\\Desktop\\vandana2", true);

            Console.WriteLine("Directory 'C:\\Users\\SQUAD\\Desktop\\vandana' exists: "
            + Directory.Exists("C:\\Users\\SQUAD\\Desktop\\vandana2").ToString());





            DirectoryInfo de = new DirectoryInfo("C:\\Users\\SQUAD\\Desktop\\vandana\\");
            DirectoryInfo[] res = de.GetDirectories();
            foreach (DirectoryInfo dObj in res)
            {
                Console.WriteLine(dObj.FullName);
                //Console.WriteLine(dObj.FullName);
            }
            Console.Read();
        }
    }
}
