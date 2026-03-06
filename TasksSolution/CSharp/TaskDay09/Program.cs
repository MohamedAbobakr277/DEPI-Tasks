using System;
using System.Collections.Generic;
using static TaskDay09.Program;

namespace TaskDay09
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part01

            #region Problem01

            //public class Prog
            //        {
            //            enum Weekdays
            //            {
            //                Monday = 1,
            //                Tuesday,
            //                Wednesday,
            //                Thursday,
            //                Friday
            //            }

            //            public static void Main()
            //            {
            //                foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //                {
            //                    Console.WriteLine($"{day} : {(int)day}");
            //                }
            //            }
            //        }

            #endregion

            #region Problem03

            //public class Person
            //    {
            //        public string Name { get; set; }
            //        public int Age { get; set; }
            //        public string Department { get; set; }

            //        public Person(string name, int age, string department)
            //        {
            //            Name = name;
            //            Age = age;
            //            Department = department;
            //        }

            //        public void PrintDetails()
            //        {
            //            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
            //        }
            //    }

            //        public class Prog
            //        {
            //            public static void Main()
            //            {
            //                Person person1 = new Person("Ali", 22, "Engineering");
            //                Person person2 = new Person("Mohamed", 30, "Marketing");

            //                person1.PrintDetails();
            //                person2.PrintDetails();
            //            }
            //        }

            #endregion

            #region Problem04

            //internal class Child : Parent
            //{
            //    public int Z { get; set; }

            //    public Child(int _X, int _Y, int _Z, decimal _salary) : base(_X, _Y)
            //    {
            //        Z = _Z;
            //        this.Salary = _salary;
            //    }

            //    public void DisplaySalary()
            //    {
            //        Console.WriteLine($"The sealed salary value is: {Salary:C}");
            //    }

            //    public new int Product()
            //    {
            //        return X * Y * Z;
            //    }

            //    public override string ToString()
            //    {
            //        return $"({X},{Y},{Z})";
            //    }

            //    public override int Sum()
            //    {
            //        return X + Y + Z;
            //    }
            //}

            //public class Parent
            //    {
            //        public int X { get; set; }
            //        public int Y { get; set; }

            //        public virtual decimal Salary { get; set; }

            //        public Parent(int x, int y) { X = x; Y = y; }
            //    }

            //    public class Prog
            //    {
            //        public static void Main()
            //        {
            //            Child myChild = new Child(10, 20, 30, 5000.50m);

            //            Console.WriteLine($"Coordinates: {myChild.ToString()}");
            //            myChild.DisplaySalary();

            //            Console.WriteLine($"Sum: {myChild.Sum()}");
            //            Console.WriteLine($"Product (New): {myChild.Product()}");
            //        }
            //    }

            #endregion

            #region Problem05
            //public static class Utility
            //{
            //    private const double pi = 3.14;
            //    public static double Pi => pi;

            //    public static double CalcRectanglePerimeter(double width, double height)
            //    {
            //        return 2 * (width + height);
            //    }

            //    public static double CmToInch(double cm)
            //    {
            //        return cm / 2.54;
            //    }
            //}


            //public class Prog
            //{
            //    public static void Main()
            //    {
            //        double w = 10.5;
            //        double h = 5.0;

            //        double perimeter = Utility.CalcRectanglePerimeter(w, h);

            //        Console.WriteLine($"Rectangle Width: {w}, Height: {h}");
            //        Console.WriteLine($"The Perimeter is: {perimeter}");
            //    }
            //}

            #endregion

            #region Problem06

            //class ComplexNumber
            //{
            //    public int Real { get; set; }
            //    public int Imag { get; set; }

            //    public override string ToString()
            //    {
            //        return $"{Real} + {Imag}i";
            //    }

            //    public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
            //    {
            //        int a = Left?.Real ?? 0;
            //        int b = Left?.Imag ?? 0;
            //        int c = Right?.Real ?? 0;
            //        int d = Right?.Imag ?? 0;

            //        return new ComplexNumber
            //        {
            //            Real = (a * c) - (b * d),
            //            Imag = (a * d) + (b * c)
            //        };
            //    }

            //    public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
            //    {
            //        return new ComplexNumber()
            //        {
            //            Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
            //            Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
            //        };
            //    }
            //}

            //public class Prog
            //    {
            //        public static void Main()
            //        {
            //            ComplexNumber c1 = new ComplexNumber { Real = 3, Imag = 2 };
            //            ComplexNumber c2 = new ComplexNumber { Real = 1, Imag = 4 };

            //            ComplexNumber result = c1 * c2;

            //            Console.WriteLine($"Number 1: {c1}");
            //            Console.WriteLine($"Number 2: {c2}");
            //            Console.WriteLine("-------------------------");
            //            Console.WriteLine($"Result of Multiplication: {result}");
            //        }
            //    }

            #endregion

            #region Problem08

            //public static class Utility
            //{
            //    private const double pi = 3.14;
            //    public static double Pi => pi;

            //    public static double CelsiusToFahrenheit(double celsius)
            //    {
            //        return (celsius * 9 / 5) + 32;
            //    }

            //    public static double FahrenheitToCelsius(double fahrenheit)
            //    {
            //        return (fahrenheit - 32) * 5 / 9;
            //    }

            //    public static double CmToInch(double cm)
            //    {
            //        return cm / 2.54;
            //    }
            //}

            //public class Prog
            //    {
            //        public static void Main()
            //        {
            //            double celsiusValue = 25.0;
            //            double fahrenheitValue = 98.6;

            //            double toFahrenheit = Utility.CelsiusToFahrenheit(celsiusValue);
            //            Console.WriteLine($"{celsiusValue}°C is equal to {toFahrenheit}°F");

            //            double toCelsius = Utility.FahrenheitToCelsius(fahrenheitValue);
            //            Console.WriteLine($"{fahrenheitValue}°F is equal to {toCelsius:F2}°C");
            //        }
            //    }

            #endregion

            #region Problem10

            //internal class Employe : ICloneable, IComparable
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public double Salary { get; set; }

            //    public override bool Equals(object obj)
            //    {
            //        if (obj == null || !(obj is Employe))
            //            return false;

            //        Employe other = (Employe)obj;

            //        return this.Id == other.Id &&
            //               this.Name == other.Name &&
            //               this.Salary == other.Salary;
            //    }

            //    public override int GetHashCode()
            //    {
            //        return HashCode.Combine(Id, Name, Salary);
            //    }

            //    public override string ToString()
            //    {
            //        return $"Emp Id is {Id}, EmpName is {Name}, EmpSalary is {Salary}";
            //    }
            //}

            //public static class Helper2<T>
            //{
            //    public static int SearchArray(T[] Arr, T Value)
            //    {
            //        for (int i = 0; i < Arr?.Length; i++)
            //        {
            //            if (Value != null && Value.Equals(Arr[i]))
            //            {
            //                return i;
            //            }
            //        }
            //        return -1;
            //    }
            //}

            #endregion

            #region Problem11

            //class Helper<T> where T : IComparable<T>
            //{
            //    public static T Max(T X, T Y)
            //    {
            //        return X.CompareTo(Y) > 0 ? X : Y;
            //    }

            //    public static void Swap(ref T X, ref T Y)
            //    {
            //        T Temp = X;
            //        X = Y;
            //        Y = Temp;
            //    }
            //}

            //static void Main()
            //{
            //    int maxInt = Helper<int>.Max(10, 20);
            //    Console.WriteLine($"Max Integer (10 vs 20): {maxInt}");

            //    double maxDouble = Helper<double>.Max(5.7, 3.2);
            //    Console.WriteLine($"Max Double (5.7 vs 3.2): {maxDouble}");

            //    string maxString = Helper<string>.Max("Apple", "Zebra");
            //    Console.WriteLine($"Max String ('Apple' vs 'Zebra'): {maxString}");
            //}

            #endregion

            #region Problem12

            //    public static class Helper2<T>
            //    {
            //        public static void ReplaceArray(T[] array, T oldValue, T newValue)
            //        {
            //            if (array == null) return;

            //            for (int i = 0; i < array.Length; i++)
            //            {
            //                if (EqualityComparer<T>.Default.Equals(array[i], oldValue))
            //                {
            //                    array[i] = newValue;
            //                }
            //            }
            //        }
            //    }

            //    public class Prog
            //    {
            //        public static void Main()
            //        {
            //            int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };

            //            Console.WriteLine("Original Integer Array: " + string.Join(", ", numbers));


            //            Helper2<int>.ReplaceArray(numbers, 2, 99);

            //            Console.WriteLine("Modified Integer Array: " + string.Join(", ", numbers));
            //            Console.WriteLine(new string('-', 40));

            //            string[] fruits = { "apple", "banana", "cherry", "apple", "date" };

            //            Console.WriteLine("Original String Array:  " + string.Join(", ", fruits));

            //            Helper2<string>.ReplaceArray(fruits, "apple", "orange");

            //            Console.WriteLine("Modified String Array:  " + string.Join(", ", fruits));
            //        }
            //    }
            //}

            #endregion

            #region Problem13

            //public struct Rectangle
            //{
            //    public double Length { get; set; }
            //    public double Width { get; set; }

            //    public override string ToString()
            //    {
            //        return $"Length: {Length}, Width: {Width}";
            //    }
            //}

            //public class Prog
            //{
            //    public static void Swap(ref Rectangle r1, ref Rectangle r2)
            //    {
            //        Rectangle temp = r1;
            //        r1 = r2;
            //        r2 = temp;
            //    }

            //    public static void Main()
            //    {
            //        Rectangle rect1 = new Rectangle { Length = 10.5, Width = 5.0 };
            //        Rectangle rect2 = new Rectangle { Length = 40.0, Width = 20.0 };

            //        Console.WriteLine($"Rectangle 1 => {rect1}");
            //        Console.WriteLine($"Rectangle 2 => {rect2}\n");

            //        Swap(ref rect1, ref rect2);

            //        Console.WriteLine($"Rectangle 1 => {rect1}");
            //        Console.WriteLine($"Rectangle 2 => {rect2}");
            //    }
            //}

            #endregion

            #region Problem14

            //public class Department
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }

            //    public Department(int id, string name)
            //    {
            //        Id = id;
            //        Name = name;
            //    }

            //    public override bool Equals(object obj)
            //    {
            //        if (obj is Department other)
            //        {
            //            return Id == other.Id && Name == other.Name;
            //        }
            //        return false;
            //    }

            //    public override int GetHashCode() => HashCode.Combine(Id, Name);

            //    public override string ToString() => Name;
            //}

            //public class Employee
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public Department Dept { get; set; }

            //    public Employee(int id, string name, Department dept)
            //    {
            //        Id = id;
            //        Name = name;
            //        Dept = dept;
            //    }

            //    public override bool Equals(object obj)
            //    {
            //        if (obj is Employee other)
            //        {
            //            return Id == other.Id &&
            //                   Name == other.Name &&
            //                   object.Equals(this.Dept, other.Dept);
            //        }
            //        return false;
            //    }

            //    public override int GetHashCode() => HashCode.Combine(Id, Name, Dept);

            //    public override string ToString() => $"[ID: {Id}] {Name} - Dept: {Dept}";
            //}

            //public static class Helper2<T>
            //{
            //    public static int SearchArray(T[] array, T target)
            //    {
            //        if (array == null) return -1;

            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i] != null && array[i].Equals(target))
            //                return i;
            //        }
            //        return -1;
            //    }

            //    public static int SearchArray(T[] array, Func<T, bool> matchCondition)
            //    {
            //        if (array == null) return -1;

            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            if (array[i] != null && matchCondition(array[i]))
            //                return i;
            //        }
            //        return -1;
            //    }
            //}

            //public class Prog
            //{
            //    public static void Main()
            //    {
            //        Department hr = new Department(1, "Human Resources");
            //        Department it = new Department(2, "IT");

            //        Employee[] employees = {
            //    new Employee(101, "Ali", hr),
            //    new Employee(102, "Mohamed", it),
            //    new Employee(103, "Omar", it)
            //};

            //        Employee exactTarget = new Employee(102, "Mohamed", new Department(2, "IT"));
            //        int exactIndex = Helper2<Employee>.SearchArray(employees, exactTarget);

            //        Console.WriteLine(exactIndex != -1
            //            ? $"Found exact match at index {exactIndex}: {employees[exactIndex]}"
            //            : "Exact match not found.");


            //        int deptIndex = Helper2<Employee>.SearchArray(employees, emp => emp.Dept.Id == 2);

            //        Console.WriteLine(deptIndex != -1
            //            ? $"Found first IT employee at index {deptIndex}: {employees[deptIndex]}"
            //            : "No employee found in that department.");
            //    }
            //}

            #endregion

            #region Problem15

            //public struct Circle
            //{
            //    public double Radius { get; set; }
            //    public string Color { get; set; }

            //    public static bool operator ==(Circle left, Circle right)
            //    {
            //        return left.Radius == right.Radius && left.Color == right.Color;
            //    }

            //    public static bool operator !=(Circle left, Circle right)
            //    {
            //        return !(left == right);
            //    }
            //}

            //public class Circle2
            //{
            //    public double Radius { get; set; }
            //    public string Color { get; set; }
            //}

            //public class Progr
            //{
            //    public static void Main()
            //    {
            //        Circle s1 = new Circle { Radius = 5.0, Color = "Red" };
            //        Circle s2 = new Circle { Radius = 5.0, Color = "Red" };

            //        Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
            //        Console.WriteLine($"s1 == s2:      {s1 == s2}");

            //        Circle2 c1 = new Circle2 { Radius = 5.0, Color = "Red" };
            //        Circle2 c2 = new Circle2 { Radius = 5.0, Color = "Red" };

            //        Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");
            //        Console.WriteLine($"c1 == c2:      {c1 == c2}");
            //    }
            //}

            #endregion


            //Part02

            #region Problem1

            //public class ArrayUtils
            //{
            //    public static T[] ReverseArray<T>(T[] originalArray)
            //    {
            //        if (originalArray == null) return null;

            //        T[] reversedArray = new T[originalArray.Length];

            //        int j = 0;
            //        for (int i = originalArray.Length - 1; i >= 0; i--)
            //        {
            //            reversedArray[j] = originalArray[i];
            //            j++;
            //        }

            //        return reversedArray;
            //    }
            //}

            //public class Program
            //{
            //    public class Person
            //    {
            //        public string Name { get; set; }
            //        public override string ToString() => Name;
            //    }

            //    public static void Main()
            //    {
            //        int[] numbers = { 1, 2, 3, 4, 5 };
            //        int[] revNumbers = ArrayUtils.ReverseArray(numbers);
            //        Console.WriteLine("Integers: " + string.Join(", ", revNumbers));

            //        string[] words = { "Apple", "Banana", "Cherry" };
            //        string[] revWords = ArrayUtils.ReverseArray(words);
            //        Console.WriteLine("Strings: " + string.Join(", ", revWords));

            //        Person[] people = { new Person { Name = "Alice" }, new Person { Name = "Bob" } };
            //        Person[] revPeople = ArrayUtils.ReverseArray(people);
            //        Console.WriteLine("Objects: " + string.Join(", ", (object[])revPeople));
            //    }
            //}

            #endregion

            #region Problem2

            //public class MyStack<T>
            //{
            //    private List<T> _items = new List<T>();

            //    public void Push(T item)
            //    {
            //        _items.Add(item);
            //    }

            //    public T Pop()
            //    {
            //        if (IsEmpty())
            //        {
            //            throw new InvalidOperationException("Stack is empty.");
            //        }

            //        int lastIndex = _items.Count - 1;
            //        T item = _items[lastIndex];
            //        _items.RemoveAt(lastIndex);
            //        return item;
            //    }

            //    public T Peek()
            //    {
            //        if (IsEmpty())
            //        {
            //            throw new InvalidOperationException("Stack is empty.");
            //        }

            //        return _items[_items.Count - 1];
            //    }

            //    public bool IsEmpty()
            //    {
            //        return _items.Count == 0;
            //    }

            //    public int Count => _items.Count;
            //}


            //public class Program
            //{
            //    public static void Main()
            //    {
            //        MyStack<int> intStack = new MyStack<int>();
            //        intStack.Push(10);
            //        intStack.Push(20);
            //        Console.WriteLine($"Top element (Peek): {intStack.Peek()}");
            //        Console.WriteLine($"Popped: {intStack.Pop()}");  
            //        Console.WriteLine($"New Top: {intStack.Peek()}");

            //        MyStack<string> stringStack = new MyStack<string>();
            //        stringStack.Push("Hello");
            //        stringStack.Push("World");
            //        Console.WriteLine($"Popped String: {stringStack.Pop()}");
            //    }
            //}

            #endregion

            #region Problem3

            //public static class ArrayHelper
            //{
            //    public static void Swap<T>(T[] array, int index1, int index2)
            //    {
            //        if (array == null) throw new ArgumentNullException(nameof(array));
            //        if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
            //            throw new IndexOutOfRangeException("Indices are out of bounds.");

            //        T temp = array[index1];
            //        array[index1] = array[index2];
            //        array[index2] = temp;
            //    }
            //}


            //public class Program
            //{
            //    public static void Main()
            //    {
            //        int[] numbers = { 10, 20, 30, 40 };
            //        ArrayHelper.Swap(numbers, 0, 3);
            //        Console.WriteLine($"Swapped: {numbers[0]} and {numbers[3]}");
            //    }
            //}
            #endregion

            #region Problem4

            //public class Prog
            //{
            //    public static void Main()
            //    {
            //        int[] intArray = { 5, 23, 10, 8, 2 };
            //        Console.WriteLine("Max Integer: " + FindMax(intArray));

            //        string[] strArray = { "Apple", "Zebra", "Mango", "Banana" };
            //        Console.WriteLine("Max String: " + FindMax(strArray));
            //    }

            //    public static T FindMax<T>(T[] array) where T : IComparable<T>
            //    {
            //        if (array == null || array.Length == 0)
            //        {
            //            throw new ArgumentException("Array is empty or null.");
            //        }

            //        T max = array[0];

            //        foreach (T element in array)
            //        {
            //            if (element.CompareTo(max) > 0)
            //            {
            //                max = element;
            //            }
            //        }

            //        return max;
            //    }
            //}

            #endregion
    }
    }
}
