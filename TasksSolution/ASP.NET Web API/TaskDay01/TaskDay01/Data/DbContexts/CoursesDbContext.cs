using Microsoft.EntityFrameworkCore;
using TaskDay01.Models;

namespace TaskDay01.Data.DbContexts
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext(DbContextOptions<CoursesDbContext> options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}
