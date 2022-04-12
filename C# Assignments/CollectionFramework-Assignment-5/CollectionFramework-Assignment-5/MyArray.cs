using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignment_5
{
	internal class MyArray
	{
		static void Main(string[] args)
		{
			//
			// Instantiate the source array.
			//
			int[] source = new int[5];
			int i;
			Console.WriteLine("Enter the Elements :");
			for ( i = 0; i < 5; i++)
			{
				source[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Source Array");
			foreach (int value1 in source)
			{
				Console.WriteLine(value1);
			}
			// Instantiate and allocate the target array.
			
			int[] target = new int[5];
			
			// Copy the source to the target.
			
			Array.Copy(source, target, 5);
			
			// Display the target array.
		
			Console.WriteLine("--- Target array ---");
			foreach (int value2 in target)
			{
				Console.WriteLine(value2);
			}
		

			Console.WriteLine();
			Console.WriteLine("Reversing the Target values ");
			Array.Reverse(target);
			foreach (int j in target)

			{
				Console.Write(j + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Sorting the values of Target");
			Array.Sort(target);
			foreach (int k in target)

			{
				Console.Write(k + " ");
			}

		}
		
	}
	
}
