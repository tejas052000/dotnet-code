using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_directory_demo
{
    class TextFileWriter
    {
        static void Main(string[] args)
        {
            WriteData();
            ReadData();
            Console.ReadLine();
        }
        public static void WriteData()
        { //create a writer and open the file
            TextWriter tw = new StreamWriter(@"C:\PRIYANKA K\C#\date.txt");
            // write a line of text to the file
            tw.WriteLine(DateTime.Now);
            tw.WriteLine("Welcome to C#");
            // close the stream
            tw.Close();
          //  Console.Read();

        }
        public static void ReadData()
        {
 // create reader & open file
            TextReader tr = new StreamReader(@"C:\PRIYANKA K\C#\date.txt");
            // read a line of text
            Console.WriteLine(tr.ReadToEnd());
         //   Console.Read();
            // close the stream
            tr.Close();
            Console.Read();
        }
    }

    //class TextFileReader
    //{
    //    static void Main(string[] args)
    //    {
           
    //    }
    //}

}
