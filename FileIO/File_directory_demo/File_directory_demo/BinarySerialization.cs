using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace File_directory_demo
{

    [Serializable]
    public class Product
    {
        public int qty, rate;
        public string name;
        public string id;
        [NonSerialized]
        public int amt;
        public Product()
        {
            id = "p001";
            name = "Nokia";
            qty = 30;
            rate = 7800;
        }
        public void calAmt()
        {
            amt = qty * rate;
            Console.WriteLine("Amount is:" + amt);
        }
    }
    public class SerialTest
    {
        public void SerializeNow()
        {
            Product p = new Product();
            FileStream fs = new FileStream("C:\\vandana\\Product.dat", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fs, p);
            fs.Close();
        }
        public void DeSerializeNow()
        {
            Product p;
            FileStream fs = new FileStream("C:\\vandana\\Product.dat", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            p = (Product)b.Deserialize(fs);
            Console.WriteLine(p.name);
           //  Console.WriteLine(p.salary);
            p.calAmt();
            fs.Close();
        }
        public static void Main(string[] s)
        {
            SerialTest st = new SerialTest();
            st.SerializeNow();
            st.DeSerializeNow();
            Console.Read();
        }
    }
    //[Serializable]
    //public class ClassToSerialize
    //{
    //    public int age;
    //    public string name;
    //    [NonSerialized]
    //    public int salary;
    //    public ClassToSerialize()
    //    {
    //        age = 30;
    //        name = "Shreeja";
    //        salary = 2000;
    //    }
    //}


}
