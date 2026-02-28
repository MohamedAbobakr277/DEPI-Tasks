using System;
using System.Collections.Generic;

namespace CSharp_Project
{
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }

        public Answer(int id, string text) { 
            AnswerId = id;
            Text = text;
        }

        public object Clone() => new Answer(this.AnswerId, this.Text);

        public override string ToString()
        {
            return $"{AnswerId}. {Text}";
        }
    }

    public class AnswerList : List<Answer> { }
}
