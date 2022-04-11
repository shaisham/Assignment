using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Circle
    {

        static void area()
        {
            //declaring variables
            double r, perimeter;

            //Pi value 
            double PI = 3.14;

            Console.WriteLine("Radius of the circle");

            // convert the string value to double 
            r = Convert.ToDouble(Console.ReadLine());

            //perimeter formula 
            perimeter = (2 * PI * r);

            Console.WriteLine("perimeter of circle is : " + perimeter);
            // area of circle formula 
            double area = (PI * r * r);

            Console.WriteLine("Area of circle :" + area);
        }
        public static void Main(String[] args)
        {
            // calling  the method from main method 
            area();
        }
    }
}

  
