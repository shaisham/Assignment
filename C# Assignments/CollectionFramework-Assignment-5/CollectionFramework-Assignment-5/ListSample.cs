using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignment_5
{
        class Employee1
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public int EmpSal { get; set; }
            public string EmpLoc { get; set; }
            public int Count { get; set; }
            public Employee1(int eid, string ename, int esal, string eloc)
            {
                this.EmpId = eid;
                this.EmpName = ename;
                this.EmpSal = esal;
                this.EmpLoc = eloc;


            }
        }
        internal class ListSample
        {
            public static void Main()
            {
                List<Employee1> emp = new List<Employee1>();
                Employee1 e1 = new Employee1(1, "nick", 20000, "Hyd");
                Employee1 e2 = new Employee1(2, "john", 15000, "Banglore");
                Employee1 e3 = new Employee1(3, "mick", 22000, "Chennai");
                Employee1 e4 = new Employee1(4, "faf", 25000, "pune");
                emp.Add(e1);
                emp.Add(e2);
                emp.Add(e3);
                emp.Add(e4);

                foreach (Employee1 i in emp)
                {
                    Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);

                }


                Console.WriteLine("Total number of employees in the list are:" + emp.Count);


                Console.ReadKey();
            }

        }
    }
