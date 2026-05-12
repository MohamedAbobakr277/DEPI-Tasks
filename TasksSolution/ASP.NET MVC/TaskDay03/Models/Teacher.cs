namespace EFCoreTask.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Salary { get; set; }
        public string Address { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}
