using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOPS
{
    internal class Employee
    {
  
       
            private int EmpNo;
            private string EmpName;
            private double Salary;
            private double HRA;
            private double TA;
            private double DA;
            private double PF;
            private double TDS;
            private double NetSalary;
            private double GrossSalary;

            public Employee(int EmpNum, string EmpNm, double Sal)
            {
                EmpNo = EmpNum;
                EmpName = EmpNm;
                Salary = Sal;
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100;
                    TA = Salary * 5 / 100;
                    DA = Salary * 15 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 10000)
                {
                    HRA = Salary * 15 / 100;
                    TA = Salary * 10 / 100;
                    DA = Salary * 20 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 15000)
                {
                    HRA = Salary * 20 / 100;
                    TA = Salary * 15 / 100;
                    DA = Salary * 25 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else if (Salary < 20000)
                {
                    HRA = Salary * 25 / 100;
                    TA = Salary * 20 / 100;
                    DA = Salary * 30 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }
                else
                {
                    HRA = Salary * 30 / 100;
                    TA = Salary * 25 / 100;
                    DA = Salary * 35 / 100;
                    GrossSalary = Salary + HRA + TA + DA;
                }

            }
            public void CalculateSalary()
            {
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
            }

       

            static void Main(string[] args)
            {
                Employee Emp1 = new Employee(1, "Shameer", 15000);
                Emp1.CalculateSalary();
                Console.WriteLine(Emp1.GrossSalary);
                Console.WriteLine(Emp1.NetSalary);
            }
        }
    }
 
