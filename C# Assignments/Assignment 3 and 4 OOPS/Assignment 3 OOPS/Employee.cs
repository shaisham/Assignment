﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee1
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
        //private double Allowances; //M
        //private double kilotrvl;   //M

        public Employee1(int Empno, string Empname, double Sal)
        {
            EmpNo = Empno;
            EmpName = Empname;
            Salary = Sal;
            //Console.WriteLine();
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
        public virtual void CalculateSalary()
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public virtual void Grosssal()
        {
            Console.WriteLine(GrossSalary);
        }
        class Manager : Employee1 // derived class 
        {

            private double Petrol_Allowance;
            private double Food_Allowance;
            private double Other_Allowances;
            public Manager(int Empno, string Empname, double Sal) : base(Empno, Empname, Sal)
            {
                Petrol_Allowance = Salary * 8 / 100;
                Food_Allowance = Salary * 13 / 100;
                Other_Allowances = Salary * 3 / 100;

            }

            //derived class method
            public override void Grosssal()
            {

                GrossSalary = GrossSalary + Petrol_Allowance + Food_Allowance + Other_Allowances;
                Console.WriteLine(GrossSalary);

            }
            public override void CalculateSalary()
            {

                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);
            }
        }
        class MarketingExecutive : Employee1  // derived class 
        {


            private double Kilometer_travel;
            private double Tour_Allowances;
            public double kilot;

            private double Telephone_Allowances = 1000;

            public MarketingExecutive(int Empno, string Empname, double Sal) : base(Empno, Empname, Sal)
            {

                Kilometer_travel = kilot;
                Tour_Allowances = 5 * Kilometer_travel;
                Telephone_Allowances = 1000;
            }

            public override void Grosssal()
            {

                GrossSalary = GrossSalary + Tour_Allowances + Telephone_Allowances;
                Console.WriteLine(GrossSalary);

            }

            public override void CalculateSalary()
            {

                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);


            }
        }
        static void Main(string[] args)
        {

            Manager M2 = new Manager(01, "shameer", 10000);
            M2.Grosssal();

            MarketingExecutive ME = new MarketingExecutive(02, "rajesh", 10000);
             ME.Grosssal();
            Console.ReadKey();

        }
    }
}