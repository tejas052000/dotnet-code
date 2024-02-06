using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    delegate int CalDelegate(int x, int y);
    class Calculator
    {
        static int result;
        public int add(int x, int y)
        {
            Console.WriteLine("Add function");
            result = result + x + y;
            Console.WriteLine("Add function {0}", result);
            return result;
        }
        public static int subtract(int x, int y)
        {
            Console.WriteLine("Subtract function");
            result = result - 10;
            Console.WriteLine("Subtract function {0}", result);
            return result;
        }
    }
    class DelChain
    {
        static void Main3()
        {
            Calculator obj1 = new Calculator();
            Calculator obj2 = new Calculator();
            CalDelegate[] delegates = new CalDelegate[]
            {
new CalDelegate(obj1.add),
new CalDelegate(obj2.add),
new CalDelegate(Calculator.subtract)
            };
            CalDelegate chain = (CalDelegate)Delegate.Combine(delegates);
            int result = chain(40, 50);
            Console.WriteLine("Result is {0}", result);
            Console.ReadLine();
            chain = (CalDelegate)Delegate.Remove(chain, delegates[2]);
            // int result = chain(40, 50);
            Console.WriteLine("Result is {0}", result);
            Console.ReadLine();
        }
    }

}
