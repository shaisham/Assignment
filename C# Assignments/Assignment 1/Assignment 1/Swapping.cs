using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Swapping
    {
        public static void Main(String[] args)
        {

            Console.Write("Enter the first Number:  ");
            int  Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number:  ");
            int  Num2 = Convert.ToInt32(Console.ReadLine());

            // value of first is assigned to temp
            int temp = Num1;
            // value of second is assigned to first
            Num1 = Num2;

            // value of temp (initial value of first) is assigned to second
            Num2 = temp;

            Console.WriteLine("After Swapping, First Number: " + Num1);
            Console.Write("After Swapping, Second Number: " + Num2);
            Console.Read();


        }
    }
}
