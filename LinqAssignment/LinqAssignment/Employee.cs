using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public static List<Employee> empList = new List<Employee>
             {


 new Employee() {EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
new Employee() {EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
new Employee() {EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987-11-14"),DOJ = DateTime.Parse("2015-4-12"),City = "Pune"},
new Employee() {EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee() {EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
new Employee() {EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
new Employee() {EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
new Employee() {EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"},

};

        static void Main(string[] args)
        {
            //DisplayAll();
            //NotMumbai();
            //AsstManager();
            LName();

            Console.ReadKey();
        }
        //Displaying all the employee details
        public static void DisplayAll()
        {
            var EmpDetails = (from e in empList select e);
            foreach (var item in EmpDetails)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }
        }
        //Not Mumbai 
        public static void NotMumbai()
        {
            var loc = (from e in empList where e.City != "Mumbai" select e);

            foreach (var item in loc)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }
        }
        //Displaying all the employees who's from the asstManager Background.

        public static void AsstManager()
        {
            var AsstManagerList = (from s in empList where s.Title == "AsstManager" select s);
            foreach (var s in AsstManagerList)
            {
                Console.WriteLine(s.EmployeeID + " " + s.FirstName + " " + s.LastName + " " + s.Title + " " + s.DOB + " " + s.DOJ + " " + s.City);
            }
        }
        //// displaying all the employees who last name ends with "s".

        public static void Nam()
        {
            var Name = (from e in empList
                        where (e.LastName.StartsWith('S' + " "))
                        select e);
            foreach (var e in Name)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);

            }
        }

    }
}


  