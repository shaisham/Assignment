using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TableOperations to = new TableOperations();
            to.insertData();
            //to.updateData(3);
            //to.displayData();
            //to.deleteData(1005);
        }
    }
    public class TableOperations
    {
        public void deleteData(int id)
        {
            EmployeeContext eobj = new EmployeeContext();
            var c =
               (from emp in eobj.Employees
                where emp.Employee_Id == id
                select emp).Single();
            eobj.Employees.Remove(c);
            eobj.SaveChanges();
            Console.WriteLine("successfully deleted");
            Console.ReadLine();
        }
        public void displayData()
        {
            EmployeeContext eobj= new EmployeeContext();
            var c = eobj.Employees;
            foreach (var item in c)
            {
                Console.WriteLine(item.Employee_Id + " " + item.Employee_Name);
                    //Console.ReadLine();
            }
        }
        public void insertData()
        {
            Employee o = new Employee();
            Console.WriteLine("Enter Employee Id: ");
            o.Employee_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            o.Employee_Name= Console.ReadLine();
            //o.Employee_Name = Console.ReadLine();
            //o.Employee_Name = Console.ReadLine();
            EmployeeContext eobj = new EmployeeContext();

            eobj.Employees.Add(o);
            eobj.SaveChanges();
            Console.WriteLine("successfully inserted");
            Console.ReadLine(); 
        }
        public void updateData(int id)

        {
            EmployeeContext eobj = new EmployeeContext();
            var c =
                (from emp in eobj.Employees
                 where emp.Employee_Id == id
                 select emp).Single();
            Console.WriteLine("Enter an Id to Update: ");
            c.Employee_Id = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Enter a name to update:");
            c.Employee_Name = Console.ReadLine();
            eobj.SaveChanges();
            Console.WriteLine("successfully updated");
            Console.ReadLine();
        }

    }
}
