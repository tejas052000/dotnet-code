using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    delegate void Printer(string s);
    class Program
    {
        static void Main4(string[] args)
        {
            // Instatiate the delegate type using an anonymous method:
            Printer p = delegate (string j)
            {
                System.Console.WriteLine(j);
            };
            // Results from the anonymous delegate call:
            p("The delegate using the anonymous method is called.");
            // The delegate instantiation using a named method "DoWork":
            p = new Printer(Program.DoWork);
            // Results from the old style delegate call:
            p("The delegate using the named method is called.");
            Console.Read();
        }
        // The method associated with the named delegate:
        static void DoWork(string k)
        {
            System.Console.WriteLine(k);
        }
    }
}
