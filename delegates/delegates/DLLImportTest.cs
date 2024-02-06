using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace delegates
{
    class DLLImportTest
    {
        // runtime
        [DllImportAttribute("User32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int h, string m, string c, int type);
       //public static int Main()
       public static int Main()
        {
            string myString;
            Console.Write("Enter your message: ");
            myString = Console.ReadLine();
            return MessageBox(1, myString, "Kavita Vispute welcomes ", 1);
        }
    }
    class Beeper
    {
        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        static extern bool Beep(int frequency, int duration);
        static void Main()
        {
            Beep(1000, 11111);
            Console.Read();
        }
    }

   
}
