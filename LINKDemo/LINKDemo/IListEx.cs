using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINKDemo
{
    class IListEx
    {
        public static void Main()
        {
            IList<string> strlist = new List<string>()
        {
            "C# Tutorials",
            "VB.NET Tutorials ",
            "Learn C++",
            "MVC Tutorials"
        };


            //LINQ Query syntax

            var result = from s in strlist
                         where s.Contains("Tutorials")
                         select s;

            

            foreach (var r in result)
            {
                Console.WriteLine("Result is:{0}",r);
            }



            //LINQ Query syntax

            var rst = strlist.Where(s => s.Contains("Tutorials"));



            foreach (var r in rst)
            {
                Console.WriteLine("Result is:{0}", r);
            }
            Console.Read();
}
    }
}
