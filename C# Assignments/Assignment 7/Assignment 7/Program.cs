using System;
using System.IO;

//1st one 
namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating dir
            string dir = @"C:\Users\shame";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //creating file in a dir
            string filepath = @"C:/Users/shame/File3.txt";

            //creates file if not exists
            if (!File.Exists(filepath))
            {
                // write into  file
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("welcome");
                    sw.WriteLine("This is sample");
                    sw.WriteLine("FileIo");
                }
            }

            // read from file
            using (StreamReader sr = File.OpenText(filepath))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //creating sub dir
            string address = Directory.CreateDirectory(dir).CreateSubdirectory("SubDir").FullName;


            //to fetch sub directories
            //string rootPath = @"C:\Users\shame\SubDir";
            string[] dirs = Directory.GetDirectories(dir, "*", SearchOption.AllDirectories);

            foreach (string i in dirs)
            {
                Console.WriteLine(i);
            }

            

            //fetchig files from dir
          


            Console.ReadKey();

        }
    }
}
