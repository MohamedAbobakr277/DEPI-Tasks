using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp_Project
{
    public class QuestionList : List<Question>
    {
        private string _logFilePath;

        public QuestionList(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        
        public new void Add(Question q)
        {
            base.Add(q);
            LogToFile(q);
        }

        private void LogToFile(Question q)
        {
            using (TextWriter writer = File.AppendText(_logFilePath))
            {
                writer.WriteLine($"[{DateTime.Now}] Added Question:");
                writer.WriteLine(q.ToString());
                writer.WriteLine("---------------------------------");
            }
        }

        public void DisplayLog()
        {
            if (!File.Exists(_logFilePath))
            {
                Console.WriteLine("Log file does not exist.");
                return;
            }

            Console.WriteLine($"----- Reading Log from {_logFilePath} -----");

            
            using (TextReader reader = File.OpenText(_logFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("----- End of Log -----");
            Console.WriteLine();
        }
    }
}
