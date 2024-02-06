using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_directory_demo
{
    public class Employee
    {
        string empid;
        string empname;
        public string EmpId
        {
            get
            {
                return empid;
            }
            set
            {
                empid = value;
            }
        }
        public string EmpName
        {
            get
            {
                return empname;
            }
            set
            {
                empname = value;
            }
        }
    }

}
