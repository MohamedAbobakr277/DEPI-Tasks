using System;

namespace CSharp_Project
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks) : base(header, body, marks)
        {
            Choices.Add(new Answer(1, "false"));
            Choices.Add(new Answer(2, "true"));
        }

        public override void Display()
        {
            Console.WriteLine($"[T/F] {ToString()}");
            foreach (var choice in Choices)
            {
                Console.WriteLine(choice);
            }
        }

        public override object Clone() => new TrueFalseQuestion(this.Header, this.Body, this.Marks);
    }
}
