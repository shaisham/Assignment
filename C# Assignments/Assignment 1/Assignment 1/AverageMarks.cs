using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class AverageMarks
    {
        static void Main(String[] args)
        {


            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Enter array {i} value: ");
                marks[i] = Convert.ToInt16(Console.ReadLine());

            }
            float sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            float average = sum / marks.Length;
            Console.WriteLine("Students marks Average is:" + average);
            //Console.ReadLine();
            int maxValue = marks.Max();
            Console.WriteLine("Highest Marks value :"+maxValue);
        }
    }
}

           
