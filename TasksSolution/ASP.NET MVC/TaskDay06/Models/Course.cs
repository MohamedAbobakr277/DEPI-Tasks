using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTask.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course Name is mandatory")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Course Name must be between 2 and 100 characters")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Degree is mandatory")]
        [Range(0, 100, ErrorMessage = "Degree must be between 0 and 100")]
        public double Degree { get; set; }

        [Required(ErrorMessage = "Minimum Degree is mandatory")]
        [Range(0, 100, ErrorMessage = "Minimum Degree must be between 0 and 100")]
        public double MinDegree { get; set; }
        
        [Required(ErrorMessage = "Department is mandatory")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<StuCrsRes> StuCrsRes { get; set; } = new List<StuCrsRes>();
    }
}
