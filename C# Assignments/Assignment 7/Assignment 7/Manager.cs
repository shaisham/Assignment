using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//4th one 
namespace Assignment7
{
    [Serializable]
    internal class Manager
    {
        public int EID;
        public String Name;
        public float Salary;
        static void Main(string[] args)
        {
            Manager MN = new Manager();
            MN.EID = 1;
            MN.Name = "shameer";
            MN.Salary = 15000;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\shame\Demo\test.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, MN);
            stream.Close();

            stream = new FileStream(@"C:\Users\shame\Demo\test.txt", FileMode.Open, FileAccess.Read);
            Manager objnew = (Manager)formatter.Deserialize(stream);

            Console.WriteLine(objnew.EID);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Salary);


            Console.ReadKey();
        }
    }
}