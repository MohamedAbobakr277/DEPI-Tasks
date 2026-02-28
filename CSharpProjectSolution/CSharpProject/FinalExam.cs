using System;
using System.Collections.Generic;

namespace CSharp_Project
{
    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan time, int noOfQuestions) : base(time, noOfQuestions) { }

        public override void ShowExam()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("             FINAL EXAM              ");
            Console.WriteLine($"Time limit: {Time.TotalMinutes} minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("-------------------------------------\n");

            Dictionary<Question, string> userAnswersLog = new Dictionary<Question, string>();

            foreach (var ans in CorrectAnswers)
            {
                Question q = ans.Key;
                q.Display();

                Console.Write("\nEnter your answer ID: ");
                string userInput = Console.ReadLine();

                userAnswersLog.Add(q, userInput);

                Console.WriteLine("-------------------------------------\n");
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("        FINAL EXAM COMPLETED         ");
            Console.WriteLine("-------------------------------------\n");
            Console.WriteLine("Your answers have been submitted successfully.");

            Console.WriteLine("--- Your Submitted Answers ---");
            foreach (var ans in userAnswersLog)
            {
                Console.WriteLine($"Question: {ans.Key.Body}");
                Console.WriteLine($"Your Answer: {ans.Value}");
                Console.WriteLine();
            }
        }
    }
}
