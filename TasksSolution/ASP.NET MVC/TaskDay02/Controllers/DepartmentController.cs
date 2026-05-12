using EFCoreTask.Data;
using EFCoreTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTask.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowAll()
        {
            var departments = _context.Departments
                .Include(d => d.Students)
                .Include(d => d.Courses)
                .ToList();
            
            return View(departments);
        }

        public IActionResult ShowDetails(int id)
        {
            var department = _context.Departments
                .Include(d => d.Students)
                .Include(d => d.Courses)
                .FirstOrDefault(d => d.Id == id);

            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction(nameof(ShowAll));
            }
            return View(department);
        }

        public IActionResult DepartmentState(int id)
        {
            var dept = _context.Departments
                .Include(d => d.Students)
                .FirstOrDefault(d => d.Id == id);

            if (dept == null)
            {
                return NotFound();
            }

            var studentsOver25 = dept.Students.Where(s => s.Age > 25).ToList();
            var totalStudentsCount = dept.Students.Count;

            var viewModel = new EFCoreTask.ViewModels.DepartmentStateViewModel
            {
                DepartmentName = dept.Name,
                StudentsOver25 = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(studentsOver25, "Id", "Name"),
                DepartmentState = totalStudentsCount > 50 ? "Main" : "Branch"
            };

            return View(viewModel);
        }
    }
}
