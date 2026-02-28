using System;

namespace CSharp_Project
{
    internal class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, string body, int marks, params string[] choiceTexts) : base(header, body, marks)
        {
            for (int i = 0; i < choiceTexts.Length; i++)
            {
                Choices.Add(new Answer(i + 1, choiceTexts[i]));
            }
        }

        public override void Display()
        {
            Console.WriteLine($"[Choose One] {ToString()}");
            foreach (var choice in Choices) {
                Console.WriteLine($"   ( ) {choice}");
            }
        }

        public override object Clone()
        {
            string[] choiceTexts = new string[Choices.Count];
            for (int i = 0; i < Choices.Count; i++)
            {
                choiceTexts[i] = Choices[i].Text;
            }
            return new ChooseOneQuestion(this.Header, this.Body, this.Marks, choiceTexts);
        }
    }
}
