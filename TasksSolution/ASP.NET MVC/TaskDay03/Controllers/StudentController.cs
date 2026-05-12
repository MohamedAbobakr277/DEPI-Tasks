using EFCoreTask.Data;
using EFCoreTask.Models;
using EFCoreTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreTask.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // --- We keep the original routes to remain compatible, but add the new ones --- 

        public IActionResult ShowAll()
        {
            var students = _context.Students.Include(s => s.Department).ToList();
            return View(students);
        }

        public IActionResult ShowDetails(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsRes)
                    .ThenInclude(scr => scr.Course)
                .FirstOrDefault(s => s.Id == id);

            if (student == null) return NotFound();
            return View(student);
        }


        // ---------- Full Lifecycle Endpoints below ----------
        
        // GET: /Student/GetAll
        public IActionResult GetAll(string searchString, int? departmentId, int page = 1)
        {
            int pageSize = 5; // Configured explicit pagination limit
            var studentsQuery = _context.Students.Include(s => s.Department).AsQueryable();

            // 1. Search Logic
            if (!string.IsNullOrEmpty(searchString))
            {
                studentsQuery = studentsQuery.Where(s => s.Name.Contains(searchString));
            }

            // 2. Department Filtering
            if (departmentId.HasValue && departmentId.Value > 0)
            {
                studentsQuery = studentsQuery.Where(s => s.DepartmentId == departmentId.Value);
            }

            // 3. Pagination calculation
            var count = studentsQuery.Count();
            int totalPages = (int)Math.Ceiling(count / (double)pageSize);

            // Bounds protection
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0) page = totalPages;

            // Resolve list execution using take
            var students = studentsQuery
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var departmentsList = _context.Departments.Select(d => new { d.Id, d.Name }).ToList();
            departmentsList.Insert(0, new { Id = 0, Name = "All Departments" });

            var viewModel = new StudentIndexViewModel
            {
                Students = students,
                Departments = new SelectList(departmentsList, "Id", "Name", departmentId),
                SearchString = searchString ?? string.Empty,
                SelectedDepartmentId = departmentId,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }

        // GET: /Student/GetById/1
        public IActionResult GetById(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .Include(s => s.StuCrsRes)
                    .ThenInclude(scr => scr.Course)
                .FirstOrDefault(s => s.Id == id);

            if (student == null) return NotFound();
            return View(student);
        }

        // GET: /Student/Add
        public IActionResult Add()
        {
            var vm = new StudentFormViewModel
            {
                Student = new Student(),
                Departments = new SelectList(_context.Departments, "Id", "Name")
            };
            return View(vm);
        }

        // POST: /Student/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(StudentFormViewModel viewModel)
        {
            // Simple validation exception checking
            if (ModelState.IsValid)
            {
                _context.Students.Add(viewModel.Student);
                _context.SaveChanges();
                return RedirectToAction(nameof(GetAll));
            }

            // Repopulate dropdown upon fail tracking mapping properly
            viewModel.Departments = new SelectList(_context.Departments, "Id", "Name", viewModel.Student.DepartmentId);
            return View(viewModel);
        }

        // GET: /Student/Edit/1
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();

            var vm = new StudentFormViewModel
            {
                Student = student,
                Departments = new SelectList(_context.Departments, "Id", "Name", student.DepartmentId)
            };
            return View(vm);
        }

        // POST: /Student/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, StudentFormViewModel viewModel)
        {
            if (id != viewModel.Student.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viewModel.Student);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Students.Any(e => e.Id == viewModel.Student.Id))
                        return NotFound();
                    else 
                        throw;
                }
                return RedirectToAction(nameof(GetAll));
            }

            viewModel.Departments = new SelectList(_context.Departments, "Id", "Name", viewModel.Student.DepartmentId);
            return View(viewModel);
        }

        // GET: /Student/Delete/1
        public IActionResult Delete(int id)
        {
            var student = _context.Students
                .Include(s => s.Department)
                .FirstOrDefault(m => m.Id == id);

            if (student == null) return NotFound();
            
            return View(student);
        }

        // POST: /Student/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(GetAll));
        }
    }
}
