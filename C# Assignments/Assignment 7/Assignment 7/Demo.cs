using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//demo
namespace Assignment7
{
    internal class FileIO
    {
        static void Main(string[] args)
        {
            WriteForFile();
            ReadForFile();
        }
        public static void WriteForFile()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\shame\Downloads\Demo\Test1.txt");
            sw.WriteLine("Hello World");
            sw.Close();
        }
        public static void ReadForFile()
        {
            StreamReader reader = new StreamReader(@"C:\Users\shame\Downloads\Demo\Test1.txt");
            Console.WriteLine((reader.ReadToEnd()));
            reader.Close();
        }
    }
}
