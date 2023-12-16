namespace Core_API.Models
{
    public abstract class EntityBase{}

    public class Department : EntityBase
    {
        public int DeptNo { get; set; }
        public string? DeptName { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Employee : EntityBase
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Designation { get; set; }
        public int Salary { get; set; }
        public int DeptNo { get; set; }
        public Department Department { get; set; } = new Department();
    }
}
