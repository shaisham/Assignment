using System;
using System.IO;


namespace Assignment_7
{
    internal class program
    { 
            static void Main(string[] args)
            {
                //creating dir
                string dir = @"C:/DirSample";

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                //creating file in a dir
                string filepath = @"C:/DirSample/File3.txt";

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
                string rootPath = @"C:/DirectorySample";
                string[] dirs = Directory.GetDirectories(dir, "*", SearchOption.AllDirectories);

                foreach (string i in dirs)
                {
                    Console.WriteLine(i);
                }

                //delete file
                File.Delete(@"C:/Sample.txt");

                //delete dir
                //string path = @"C:/DirectorySample";
                //Directory.Delete(path, true);


                //fetchig files from dir
                // string[] filePaths = Directory.GetFiles(@"E:/DirectorySample");


                Console.ReadKey();

            }
        }
    }

