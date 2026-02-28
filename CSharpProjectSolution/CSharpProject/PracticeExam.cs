using System;
using System.Collections.Generic;

namespace CSharp_Project
{
    public class PracticeExam : Exam
    {
        public PracticeExam(TimeSpan time, int noOfQuestions) : base(time, noOfQuestions) { }

            public override void ShowExam()
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("           PRACTICE EXAM             ");
                Console.WriteLine($"Time limit: {Time.TotalMinutes} minutes");
                Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
                Console.WriteLine("---------------------------------------\n");

                int totalMarks = 0, earnedMarks = 0;

                Dictionary<Question, string> userAnswersLog = new Dictionary<Question, string>();

                foreach (var ans in CorrectAnswers)
                {
                    Question q = ans.Key;
                    totalMarks += q.Marks;

                    q.Display();
                    Console.Write("\nEnter your answer ID: ");
                    string userInput = Console.ReadLine();

                    userAnswersLog.Add(q, userInput);

                    Console.WriteLine("---------------------------------------\n");
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("          PRACTICE EXAM RESULTS      ");
                Console.WriteLine("---------------------------------------\n");

                foreach (var ans in CorrectAnswers)
                {
                    Question q = ans.Key;
                    AnswerList correctAnswers = ans.Value;
                    string uAnswer = userAnswersLog[q];

                    Console.WriteLine($"Question: {q.Body}");
                    Console.WriteLine($"Your Answer: {uAnswer}");

                    string correctStr = "";
                    for (int i = 0; i < correctAnswers.Count; i++)
                    {
                        correctStr += $"{correctAnswers[i].AnswerId} ({correctAnswers[i].Text})";
                        if (i < correctAnswers.Count - 1)
                        {
                            correctStr += ", ";
                        }
                    }
                    Console.WriteLine($"Correct Answer(s): {correctStr}");

                    List<int> correctIds = new List<int>();
                    foreach (Answer a in correctAnswers)
                    {
                        correctIds.Add(a.AnswerId);
                    }

                    List<int> userIds = new List<int>();
                    string[] rawInput = uAnswer.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string strId in rawInput)
                    {
                        if (int.TryParse(strId, out int parsedId))
                        {
                            userIds.Add(parsedId);
                        }
                    }

                    bool isCorrect = false;

                    if (userIds.Count == correctIds.Count)
                    {
                        userIds.Sort();
                        correctIds.Sort();

                        isCorrect = true;
                        for (int i = 0; i < userIds.Count; i++)
                        {
                            if (userIds[i] != correctIds[i])
                            {
                                isCorrect = false;
                                break;
                            }
                        }
                    }

                    if (isCorrect)
                    {
                        Console.WriteLine($"Result: Correct! (+{q.Marks} Marks)");
                        earnedMarks += q.Marks;
                    }
                    else
                    {
                        Console.WriteLine($"Result: Incorrect. (0/{q.Marks} Marks)");
                    }
                    Console.WriteLine("\n-------------------------------------");
                }

                Console.WriteLine($"\nFinal Score: {earnedMarks} / {totalMarks}");
            }
    }
}
