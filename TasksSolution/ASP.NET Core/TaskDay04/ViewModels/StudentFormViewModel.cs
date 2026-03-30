using EFCoreTask.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EFCoreTask.ViewModels
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; } = new Student();
        public SelectList Departments { get; set; } = null!;
    }
}
