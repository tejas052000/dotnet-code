using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File_directory_demo
{
    public partial class Form1 : Form
    {
        static string path;
        public Form1()
        {
            InitializeComponent();
            path=@"C:\vc20\mydata.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
         else
            {
                MessageBox.Show("sorry...00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(path))
            {
                DirectoryInfo d = new DirectoryInfo(path);
                d.Create();
            }
            else
            {
                MessageBox.Show("sorry...already Directory exists!!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                MessageBox.Show("sorry...already File exists!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                fi.Create();
            }
            else
            {
                MessageBox.Show("sorry...already File exists!!");
            }
        }
    }
}
