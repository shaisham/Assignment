using System;
using System.Reflection;

namespace Assign8
{
    internal class Employee1
    {
   


        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }



        public Employee1(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }
   
        public void employeeDetails()
        {
            Console.WriteLine("Employee Id :" + EmpId);
            Console.WriteLine("Employee name :" + EmpName);
            Console.WriteLine("Employee Salary :" + EmpSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1(1, "shameer", 15000);

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            emp.employeeDetails();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] mi = item.GetMethods();

                foreach (var method in mi)
                {
                    Console.WriteLine(method.Name);

                }
            }
            Console.ReadLine();
        }
    }
}
