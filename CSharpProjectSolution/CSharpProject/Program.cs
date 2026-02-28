using System;

namespace CSharp_Project
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Subject csharpCourse = new Subject { SubjectId = 1, SubjectName = "OOP" };
                Student std1 = new Student("Mohamed");
                Student std2 = new Student("Omar");
                csharpCourse.EnrolledStudents.Add(std1);
                csharpCourse.EnrolledStudents.Add(std2);

                Exam practice = new PracticeExam(TimeSpan.FromMinutes(30), 5);
                Exam final = new FinalExam(TimeSpan.FromHours(2), 20);

                foreach (var student in csharpCourse.EnrolledStudents)
                {
                    practice.ExamStartingEvent += student.OnExamStarting;
                    final.ExamStartingEvent += student.OnExamStarting;
                }

                Console.WriteLine("Select Exam Type:\n1. Practice Exam\n2. Final Exam");
                string choice = Console.ReadLine();

                Exam selectedExam = null;

                if (choice == "1")
                {
                    selectedExam = practice;
                }
                else if (choice == "2")
                {
                    selectedExam = final;
                }

                if (selectedExam != null)
                {
                    selectedExam.Mode = ExamMode.Starting;
                    selectedExam.ShowExam();
                    selectedExam.Mode = ExamMode.Finished;
                }
            }
        }
    }
