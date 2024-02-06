using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDemo
{
    internal class Program
    {
        static void Main(string[] args)

        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"C:\Users\SQUAD\Desktop\vandana\demo.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value);
                userNode.Attributes["age"].Value = (age + 1).ToString();
            }
            xmlDoc.Save(@"C:\Users\SQUAD\Desktop\vandana\demo.xml");
            Console.Read();


        }
    }
}
