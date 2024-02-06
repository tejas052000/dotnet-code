using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class BasicAttributeMethod
    {
        public void myCurrentMethod()
        {
        }
      [Obsolete]
        public void MyFirstMethod()
        {
            Console.WriteLine("Called myfirst method");
        }
       [ObsoleteAttribute]
        public void MySecondMethod()
        {
            Console.WriteLine("Called Second method");
        }
       [Obsolete("you should not use this method pls use MyCurrentMethod", false)]
        public void MyDeprecatedMethod()
        {
            Console.WriteLine("Called deprecated method");
        }
        public void display()
        {
        }
    }
    class Myclient
    {
        static void Main5(string[] args)
        {
            BasicAttributeMethod ba = new BasicAttributeMethod();
            //ba.MyFirstMethod();
            //ba.MySecondMethod();
            //ba.MyDeprecatedMethod();
            Console.ReadLine();
        }
    }
}
