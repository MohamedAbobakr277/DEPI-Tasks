using EFCoreTask.Data;
using EFCoreTask.Models;
using EFCoreTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreTask.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var courses = _context.Courses
                .Include(c => c.Department)
                .ToList();
            
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = _context.Courses
                .Include(c => c.Department)
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        public IActionResult Add()
        {
            var viewModel = new CourseFormViewModel
            {
                Departments = new SelectList(_context.Departments, "Id", "Name")
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CourseFormViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(viewModel.Course);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            viewModel.Departments = new SelectList(_context.Departments, "Id", "Name");
            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            var viewModel = new CourseFormViewModel
            {
                Course = course,
                Departments = new SelectList(_context.Departments, "Id", "Name")
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CourseFormViewModel viewModel)
        {
            if (id != viewModel.Course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viewModel.Course);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(viewModel.Course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            viewModel.Departments = new SelectList(_context.Departments, "Id", "Name");
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var course = _context.Courses
                .Include(c => c.Department)
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
