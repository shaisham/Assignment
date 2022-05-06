using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

using System.Linq;

namespace CodeFirstApproach
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("EmployeeContextconnectionString")
        {
        }
        public DbSet<Employee> Employees { get; set; }  




    }
    public class Employee
    {
        [Key]
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string Employee_Name { get; set; }
    }
}

 