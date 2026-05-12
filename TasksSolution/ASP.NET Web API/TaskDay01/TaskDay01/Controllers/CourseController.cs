using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskDay01.Data.DbContexts;
using TaskDay01.Models;

namespace TaskDay01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public readonly CoursesDbContext _context;
        public CourseController(CoursesDbContext context)
        {
            _context = context;
        }

        // /api/Course      httpGet
        [HttpGet]
        public IActionResult Get()
        {
            List<Course> courses = _context.Courses.ToList();
            if(courses.Count == 0) return NotFound();
            return Ok(courses);
        }

        // /api/Course/id       httpGet
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            Course course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if(course == null) return NotFound();
            return Ok(course);
        }

        // /api/Course/Name     httpGet
        [HttpGet("{Name:alpha}")]
        public IActionResult CourseByName(string name)
        {
            Course course = _context.Courses.FirstOrDefault(c => c.Crs_name == name);
            if(course == null) return NotFound();
            return Ok(course);
        }

        // /api/Course/id       httpPut
        [HttpPut("{id}")]
        public IActionResult Put(int id, Course NewCourse)
        {
            Course OldCourse = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (id != NewCourse.Id) return BadRequest();
            if (OldCourse != null)
            {
                OldCourse.Crs_name = NewCourse.Crs_name;
                OldCourse.Crs_desc = NewCourse.Crs_desc;
                OldCourse.Duration = NewCourse.Duration;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }

        // /api/Course      httpPost
        [HttpPost]
        public IActionResult Post(Course course)
        {
            if (course == null) return BadRequest();
            _context.Add(course);
            _context.SaveChanges();
            return Created();
        }

        // /api/Course/id      httpDelete
        [HttpDelete("{id:int}")]
        public IActionResult deleteCourse(int id)
        {
            Course course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null) return NotFound();
            _context.Remove(course);
            _context.SaveChanges();
            List<Course> courses = _context.Courses.ToList();
            return Ok(courses);
        }
    }
}
