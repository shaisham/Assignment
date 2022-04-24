using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQAssignment
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
            // Nam();
            // Name();
            //DOJoining();
            //DateOfBirth();
            // DesignationDetails();
            //TotalNumber();
            //EmployeesBelongingToChennai();
            // HighestEmpId();
            // AfterJoining();
            //Associate();
            //Citybase();
            //CityTitlebase();
            YoungerEmployee();





            Console.ReadKey();
        }
        //Displaying all the employee details
        public static void DisplayAll()
        {
            var EmpDetails = (from e in empList
                              select e);
            foreach (var item in EmpDetails)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }
        }
        //Not Mumbai 
        public static void NotMumbai()
        {
            var loc = (from e in empList
                       where e.City != "Mumbai"
                       select e);

            foreach (var item in loc)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }
        }
        //Displaying all the employees who's from the asstManager Background.

        public static void AsstManager()
        {
            var AsstManagerList = (from s in empList
                                   where s.Title == "AsstManager"
                                   select s);
            foreach (var s in AsstManagerList)
            {
                Console.WriteLine(s.EmployeeID + " " + s.FirstName + " " + s.LastName + " " + s.Title + " " + s.DOB + " " + s.DOJ + " " + s.City);
            }
        }
        // displaying all the employees who last name ends with "s".

        public static void Nam()
        {
            var Name = (from e in empList
                        where e.LastName.StartsWith("S")
                        select e);
            foreach (var e in Name)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);

            }
        }

        //last name ends with s
        public static void Name()
        {
            var Name = (from e in empList
                        where (e.LastName.StartsWith('S' + " "))
                        select e);
            foreach (var e in Name)
            {
                Console.WriteLine(e.EmployeeID + " " + e.FirstName + " " + e.LastName + " " + e.Title + " " + e.DOB + " " + e.DOJ + " " + e.City);

            }
        }
        public static void DOJoining()
        {
            var r = from emp in empList
                    where emp.DOJ < DateTime.Parse("1/1/2015")
                    select emp;
            foreach (var obj in r)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }
        public static void DateOfBirth()
        {
            var r = from emp in empList
                    where emp.DOB > DateTime.Parse("1/1/1990")
                    select emp;
            foreach (var obj in r)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }

        public static void DesignationDetails()
        {
            var r = from emp in empList
                    where emp.Title == "Consultant" || emp.Title == "Associate"
                    select emp;
            foreach (var obj in r)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }

        public static void TotalNumber()
        {
            var result = from Employee in empList
                         select Employee;
            Console.WriteLine(result.Count());
            foreach (var obj in result)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }
        //employees belong to chennai
        public static void EmployeesBelongingToChennai()
        {

            var loc = (from e in empList
                       where e.City == "Chennai"
                       select e);

            foreach (var item in loc)
            {
                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);
            }
        }
        // display highest emp Id
        public static void HighestEmpId()
        {
            var Emp = (from e in empList
                       select e);

            foreach (var item in Emp)
            {

                Console.WriteLine(item.EmployeeID + " " + item.FirstName + " " + item.LastName + " " + item.Title + " " + item.DOB + " " + item.DOJ + " " + item.City);

            }

        }

        //employees after joining  1/1/2015
        public static void AfterJoining()
        {
            var Joining = from emp in empList
                          where emp.DOJ > DateTime.Parse("1/1/2015")
                          select emp;
            foreach (var obj in Joining)
            {
                Console.WriteLine(obj.EmployeeID + " " + obj.FirstName + " " + obj.LastName + " " + obj.Title + " " + obj.DOB + " " + obj.DOJ + " " + obj.City);
            }
        }

        //employees who are not associate

        public static void Associate()
        {
            var Asso = (from s in empList
                        where s.Title != "Associate"
                        select s);
            foreach (var s in Asso)
            {
                Console.WriteLine(s.EmployeeID + " " + s.FirstName + " " + s.LastName + " " + s.Title + " " + s.DOB + " " + s.DOJ + " " + s.City);
            }
        }


        //total no of employees based on city

        public static void Citybase()
        {

            var cityb = (from s in empList
                         where s.City != null
                         
                      orderby s.City
                         select s);


            foreach (var s in cityb)
            {
                Console.WriteLine(s.EmployeeID + " " + s.FirstName + " " + s.LastName + " " + s.Title + " " + s.DOB + " " + s.DOJ + " " + s.City);
            }

        }


        //total no of employees based on city and title

        public static void CityTitlebase()
        {

            var cityb = (from s in empList
                         where s.City != null && s.Title != null
                         orderby s.City
                         orderby s.Title
                         select s);


            foreach (var s in cityb)
            {
                Console.WriteLine(s.EmployeeID + " " + s.FirstName + " " + s.LastName + " " + s.Title + " " + s.DOB + " " + s.DOJ + " " + s.City);
            }

        }
        //total no of employee who is youngest in the list

        //public static void YoungestEmpDob()
        //{
        public static void YoungerEmployee()
        {

            var query = empList.OrderByDescending(e => e.DOB).FirstOrDefault();

            Console.WriteLine(query.FirstName);

        }



    }
    }
