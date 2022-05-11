using System.ComponentModel.DataAnnotations;

namespace EFCoreCodeFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string designation { get; set; }
        public int Salary { get; set; }
    }
}
