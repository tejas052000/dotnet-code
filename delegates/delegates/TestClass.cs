using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// EXAMPLE FOR SINGLE DELEGATES
namespace delegates
{
    //define delegate
    delegate int SingleDelegate();
    class TestClass
    {
        public string Upper(string s)
        {
            Console.WriteLine("The string is{0}", s.ToUpper());
            return s;
        }
        public int Instance_Method()
        {
            Console.WriteLine("This is the instance method.");
            return 0;
        }
        static public int Static_Method()
        {
            Console.WriteLine("This is the static method.");
            return 0;
        }

    }
    public class ImplClass
    {
        static public void Main()
        {
            TestClass p = new TestClass();
            //create instance of delegate
            //Map the delegate to the instance method:
            SingleDelegate d = new SingleDelegate(p.Instance_Method);
            // Call the instance method:
            //Invoke function
            d.Invoke();
            //Map to the static method:
            d = new SingleDelegate(TestClass.Static_Method);
            // Call the static method:
            d();
            Console.ReadLine();
        }
    }
}
