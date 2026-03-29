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

                // Create sample questions
                TrueFalseQuestion tfQ = new TrueFalseQuestion("Q1", "C# is an object-oriented programming language.", 5);
                AnswerList tfAns = new AnswerList { new Answer(2, "true") };

                ChooseOneQuestion coQ = new ChooseOneQuestion("Q2", "Which keyword is used to declare a class in C#?", 5, "method", "class", "void");
                AnswerList coAns = new AnswerList { new Answer(2, "class") };

                ChooseAllQuestion caQ = new ChooseAllQuestion("Q3", "Which of these are value types in C#?", 10, "int", "string", "bool", "object");
                AnswerList caAns = new AnswerList { new Answer(1, "int"), new Answer(3, "bool") };

                // Add questions to Practice Exam
                practice.CorrectAnswers.Add(tfQ, tfAns);
                practice.CorrectAnswers.Add(coQ, coAns);
                practice.CorrectAnswers.Add(caQ, caAns);

                // Add questions to Final Exam
                final.CorrectAnswers.Add(tfQ, tfAns);
                final.CorrectAnswers.Add(coQ, coAns);
                final.CorrectAnswers.Add(caQ, caAns);

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
