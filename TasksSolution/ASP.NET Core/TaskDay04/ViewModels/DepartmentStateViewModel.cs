using Microsoft.AspNetCore.Mvc.Rendering;

namespace EFCoreTask.ViewModels
{
    public class DepartmentStateViewModel
    {
        public string DepartmentName { get; set; } = string.Empty;
        public SelectList StudentsOver25 { get; set; } = null!;
        public string DepartmentState { get; set; } = string.Empty;
    }
}
