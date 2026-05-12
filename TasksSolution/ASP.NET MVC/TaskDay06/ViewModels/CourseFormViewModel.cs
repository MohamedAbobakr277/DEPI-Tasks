using EFCoreTask.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EFCoreTask.ViewModels
{
    public class CourseFormViewModel
    {
        public Course Course { get; set; } = new Course();
        public SelectList Departments { get; set; } = null!;
    }
}
