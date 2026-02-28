using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project
{
    public class Student
    {
        public string Name { get; set; }
        public Student(string name) { Name = name; }

        public void OnExamStarting(object sender, EventArgs e)
        {
            Console.WriteLine($"Notification for {Name}: The exam is now starting!");
        }
    }
}
