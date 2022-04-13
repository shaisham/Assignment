using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_OOPS
{
    internal class MyStack
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elemnts in stack :" + "\n");
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            foreach (var item in st)
            {
                Console.WriteLine(item + "\n");
            }
            int PopName = st.Pop();
            
          
            Console.Write("the popout int is : " + PopName);


            Console.ReadLine();

        }
    }
}

