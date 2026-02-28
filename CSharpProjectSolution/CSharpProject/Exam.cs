using System;
using System.Collections.Generic;

namespace CSharp_Project
{
    public enum ExamMode { Queued, Starting, Finished }
    public abstract class Exam
    {
        public TimeSpan Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, AnswerList> CorrectAnswers { get; set; }

        private ExamMode _mode = ExamMode.Queued;

        
        public delegate void ExamModeChangedHandler(object sender, EventArgs e);
        public event ExamModeChangedHandler ExamStartingEvent;

        public ExamMode Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                if (_mode == ExamMode.Starting)
                {
                    
                    ExamStartingEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Exam(TimeSpan time, int noOfQuestions)
        {
            Time = time;
            NumberOfQuestions = noOfQuestions;
            CorrectAnswers = new Dictionary<Question, AnswerList>();
        }

        public abstract void ShowExam();
    }
}
