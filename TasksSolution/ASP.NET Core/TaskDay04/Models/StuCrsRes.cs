namespace EFCoreTask.Models
{
    public class StuCrsRes
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public double Grade { get; set; }
    }
}
