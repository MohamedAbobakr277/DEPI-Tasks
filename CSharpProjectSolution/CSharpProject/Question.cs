using System;

namespace CSharp_Project
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Choices { get; set; }

        public Question() : this("Default Header", "Default Body", 0) { }

        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Choices = new AnswerList();
        }

        public abstract void Display();

        public int CompareTo(Question other) { 
            if (other == null) return 1;
            return this.Marks.CompareTo(other.Marks);
        }

        public override bool Equals(object obj)
        {
            if (obj is Question q)
            {
                return this.Body == q.Body && this.Header == q.Header;
            }
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Header, Body, Marks);
        public override string ToString() => $"{Header}\n{Body}\nMarks: {Marks}";

        public abstract object Clone();
    }
}
