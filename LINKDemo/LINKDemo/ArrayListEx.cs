using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LINKDemo
{
    class ArrayListEx
    {
        public static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add("One");
            arr.Add(1);
            arr.Add("Four");
            arr.Add(5);
        
            arr.Add(new student() { StudId = 9, Sname = "Joya" }); 

            
            var strres = from s in arr.OfType<string>() select s;  //ofType-Filters an element of an IEnumerable based on specific type. 
            
            foreach(string   r in strres)
            {
                Console.WriteLine("string elements are" + r);
            }

            var intres = from s in arr.OfType<int>() select s;

            foreach (int i in intres)
            {
                Console.WriteLine("Integer elements are" + i);
            }

            var rv = from s in arr.OfType<student>() select s;

            foreach (var v in rv)
            {
                Console.WriteLine("Id is :{0}\nName is:{1}", v.StudId, v.Sname);
            }
           
            Console.Read();
        }
    }
}
