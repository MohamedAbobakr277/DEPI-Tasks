using EFCoreTask.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EFCoreTask.ViewModels
{
    public class StudentIndexViewModel
    {
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public SelectList Departments { get; set; } = null!;
        public string SearchString { get; set; } = string.Empty;
        public int? SelectedDepartmentId { get; set; }
        
        // Pagination
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
