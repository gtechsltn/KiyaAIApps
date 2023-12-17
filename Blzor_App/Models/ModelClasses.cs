using System.ComponentModel.DataAnnotations;
namespace Blzor_App.Models
{
    public abstract class EntityBase{}

    public class Department : EntityBase
    {
        [Required(ErrorMessage ="DeptNo is required")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is required")]
        public string? DeptName { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string? Location { get; set; }
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }
        public List<Employee>? Employees { get; set; } 
    }

    public class Employee : EntityBase
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Designation { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
        public Department? Department { get; set; }
    }
}
