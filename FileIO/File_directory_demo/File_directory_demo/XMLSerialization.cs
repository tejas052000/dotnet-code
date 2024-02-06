using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace File_directory_demo
{
    class XMLSerialization
    {
        
        public static void Main()
        {
            
            FileStream fs = new FileStream("C:\\PRIYANKA K\\Employee.xml", FileMode.OpenOrCreate);
            Employee emp = new Employee();
            emp.EmpId = "E098";
            emp.EmpName = "Visual Coder";
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp);
            fs.Close();

            Console.WriteLine("Serialized");

            FileStream fs1 = new FileStream("C:\\PRIYANKA K\\Employee.xml", FileMode.Open);
            emp = (Employee)xs.Deserialize(fs1);
            Console.WriteLine("Emp id is {0} and name is {1}", emp.EmpId, emp.EmpName);
            fs1.Close();
            Console.Read();
        }
    }
}
