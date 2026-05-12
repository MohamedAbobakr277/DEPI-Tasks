using EFCoreTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTask.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<StuCrsRes> StuCrsRes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreTaskDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StuCrsRes>()
                .HasKey(scr => new { scr.StudentId, scr.CourseId });

            modelBuilder.Entity<StuCrsRes>()
                .HasOne(scr => scr.Student)
                .WithMany(s => s.StuCrsRes)
                .HasForeignKey(scr => scr.StudentId);

            modelBuilder.Entity<StuCrsRes>()
                .HasOne(scr => scr.Course)
                .WithMany(c => c.StuCrsRes)
                .HasForeignKey(scr => scr.CourseId);

            
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Courses)
                .WithOne(c => c.Department)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Teachers)
                .WithOne(t => t.Department)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Teachers)
                .WithOne(t => t.Course)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
