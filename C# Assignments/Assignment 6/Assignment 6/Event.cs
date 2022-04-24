using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    delegate void digSimple();
    internal class Event
    {
        public static event digSimple Simply;
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the c# programming");
        }
        public static void sayHello ()
        {
            Simply();
        }
        static int Main()
        {
            Simply += new digSimple(Welcome);
            sayHello();
            return 0;
        }
    }
}
