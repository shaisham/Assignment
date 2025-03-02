﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// 3rd one 
namespace Assignment_7
{
    internal class Employee1
    {

            public static void Main()
            {
                string myPath = @"D:/Manager/Sample.txt";

                string mySecondPath = @"D:/Manager/Sample.txt";

                Console.Write("Enter the salary of an Employee to find Food ,Petrol,Other Allowances :");
                Manager1 m = new Manager1(Convert.ToInt32(Console.ReadLine()));

                m.Foodie();
                m.Petrol();
                m.Others();

                m.GrossSalary();
                m.CalculateSalary();
                m.Mprint();

                /* Deserialize first object*/

                DataSerializer ds = new DataSerializer();


                ds.BinarySerialize(m, myPath);
                Console.WriteLine("Test Deserialize");




                FileStream fs = new FileStream(myPath, FileMode.OpenOrCreate);
                BinaryFormatter bs = new BinaryFormatter();
                Manager1 mm = (Manager1)bs.Deserialize(fs);
                Console.WriteLine("Successfully Deserialized And Deserialized The object");
                Console.WriteLine("");
                Console.WriteLine("Manager salary:{0}", mm.CalculateSalary());


                Console.WriteLine("Manager salary {0}:", mm);

                fs.Close();


                Console.Write("Enter the salary of an Employee to find Tele and Tour Allowances:");

                MarketingExecutive1 me = new MarketingExecutive1(Convert.ToDouble(Console.ReadLine()));
                me.Grosssalary();
                me.CalculateSalary();
                me.Mprint();

                //Desrialized second object
                DataSerializer dss = new DataSerializer();


                ds.BinarySerialize(me, mySecondPath);
                Console.WriteLine("Test Deserialize");

                FileStream fss = new FileStream(mySecondPath, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                MarketingExecutive1 marketingExecutive = (MarketingExecutive1)bf.Deserialize(fss);
                Console.WriteLine("Successfully Deserialized And Deserialized The object");
                Console.WriteLine("");

                Console.WriteLine("MarketingExecutive salary After deserialized:{0}", marketingExecutive.CalculateSalary());

                fss.Close();

            }

        }
        //Manager class
        [Serializable]
        public class Manager1
        {
            private double petrol;
            private double food;
            private double others;
            private double sal;
            private double gross;
            private double netSal;
            private double Pf, tds;

            public Manager1(double Esalary)
            {
                sal = Esalary;


                //  Console.WriteLine(sal);
            }
            public double Foodie()
            {
                food = sal * 0.13;

                return food;
            }
            public double Petrol()
            {
                petrol = sal * 0.08;
                return petrol;
            }
            public double Others()
            {
                others = sal * 0.03;

                return others;
            }
            public double GrossSalary()
            {
                gross = sal + food + petrol + others;
                return gross;
            }
            public double CalculateSalary()
            {
                Pf = (gross * 0.10);
                tds = (gross * 0.18);
                netSal = gross - (Pf + tds);

                return netSal;

            }

            public void Mprint()
            {
                Console.WriteLine("Emp Petrol Allowances:{0}", petrol);
                Console.WriteLine("Emp Food Allowances:{0}", food);
                Console.WriteLine("Emp Petrol Allowances:{0}", others);
                Console.WriteLine("Emp Gross Salary with Allowances:{0}", gross);
                Console.WriteLine("Emp Net Salary:{0}", netSal);
            }

        }
        //Marketing Excutive Class
        [Serializable]
        public class MarketingExecutive1
        {
            private double sal;
            private double km;
            private double tourAllowances;
            private double telephoneAllowances;
            private double netSal, Pf, tds, gross;
            public MarketingExecutive1(double Esal)
            {
                this.sal = Esal;
            }
            public double Grosssalary()
            {
                Console.Write("Enter the Total Kilometers Covered:");
                km = Convert.ToDouble(Console.ReadLine());
                tourAllowances = 5 * km;
                telephoneAllowances = 1000;
                gross = sal + tourAllowances + telephoneAllowances;
                Console.WriteLine(gross);
                return gross;
            }

            public double CalculateSalary()
            {
                Pf = (gross * 0.10);
                tds = (gross * 0.18);
                netSal = gross - (Pf + tds);
                // Console.WriteLine("Employee Salary:" + Netsal);
                return netSal;

            }
            public void Mprint()
            {
                Console.WriteLine("Emp Travel Allowances:{0}", tourAllowances);
                Console.WriteLine("Emp Telephone Allowances:{0}", telephoneAllowances);
                Console.WriteLine("Emp Gross salary with  Allowances:{0}", gross);
                Console.WriteLine("Emp Net Salary :{0}", netSal);
            }

        }
        class DataSerializer
        {
            public void BinarySerialize(Object data, string filePath)
            {
                FileStream fileStream;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                fileStream = File.Create(filePath);
                binaryFormatter.Serialize(fileStream, data);
                fileStream.Close();
            }


        }
    }

