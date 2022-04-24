using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ArrayOfIntegers
    {
        static void sumOfArray()
        {
            int[] arr;
            arr = new int[] { 1, 2, 3, 4, 5 ,6,7};
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }

            Console.WriteLine("sum of all the integers of an array : " + sum);


        }

        static void Main()
        {
            sumOfArray();
        }
    }
}

