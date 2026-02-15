using System;

namespace TaskDay07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part01

            #region Problem01

            //public class Car
            //{

            //    public int Id { get; set; }
            //    public string Brand { get; set; }
            //    public decimal Price { get; set; }


            //    public Car()
            //    {
            //        Id = 0;
            //        Brand = "Unknown";
            //        Price = 0.0m;
            //    }


            //    public Car(int id)
            //    {
            //        Id = id;
            //        Brand = "Unknown";
            //        Price = 0.0m;
            //    }


            //    public Car(int id, string brand)
            //    {
            //        Id = id;
            //        Brand = brand;
            //        Price = 0.0m;
            //    }


            //    public Car(int id, string brand, decimal price)
            //    {
            //        Id = id;
            //        Brand = brand;
            //        Price = price;
            //    }


            //    public void DisplayInfo()
            //    {
            //        Console.WriteLine($"ID: {Id}, Brand: {Brand}, Price: ${Price}");
            //    }
            //}

            //Car car1 = new Car();
            //Car car2 = new Car(101);
            //Car car3 = new Car(102, "Toyota");
            //Car car4 = new Car(103, "Tesla", 45000.50m);

            //car1.DisplayInfo();
            //car2.DisplayInfo();
            //car3.DisplayInfo();
            //car4.DisplayInfo();

            /*
             * When you do not define any constructors in a class, the C# compiler automatically provides a hidden,
             * parameterless "default" constructor. This ensures that an object can always be instantiated.
             * However, the moment you define any constructor, the compiler assumes you want to control exactly
             * how that object is initialized.
             */

            #endregion

            #region Problem02

            //public class Calculator
            //{

            //    public int Sum(int a, int b)
            //    {
            //        return a + b;
            //    }


            //    public int Sum(int a, int b, int c)
            //    {
            //        return a + b + c;
            //    }


            //    public double Sum(double a, double b)
            //    {
            //        return a + b;
            //    }
            //}

            //Calculator calc = new Calculator();


            //int result1 = calc.Sum(10, 20);
            //Console.WriteLine($"Sum of 2 ints (10 + 20): {result1}");

            //int result2 = calc.Sum(10, 20, 30);
            //Console.WriteLine($"Sum of 3 ints (10 + 20 + 30): {result2}");

            //double result3 = calc.Sum(15.5, 2.3);
            //Console.WriteLine($"Sum of 2 doubles (15.5 + 2.3): {result3}");

            #endregion

            #region Problem03

            //public class Parent
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }

            //    // Base constructor
            //    public Parent(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }
            //}

            //public class Child : Parent
            //{
            //    public int Z { get; set; }

            //    public Child(int x, int y, int z) : base(x, y)
            //    {
            //        Z = z;
            //    }

            //    public void DisplayCoordinates()
            //    {
            //        Console.WriteLine($"Values: X={X}, Y={Y}, Z={Z}");
            //    }
            //}

            //class Prog
            //{
            //    static void Main()
            //    {

            //        Child myObj = new Child(10, 20, 30);

            //        myObj.DisplayCoordinates();
            //    }
            //}

            #endregion

            #region Problem04

            //public class Parent
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }

            //    public Parent(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }


            //    public virtual int Product()
            //    {
            //        return X * Y;
            //    }
            //}


            //public class Child : Parent
            //{
            //    public int Z { get; set; }

            //    public Child(int x, int y, int z) : base(x, y)
            //    {
            //        Z = z;
            //    }


            //    public new int Product()
            //    {
            //        return X * Y * Z;
            //    }



            //    /*
            //    public override int Product() 
            //    {
            //        return X * Y * Z;
            //    }
            //    */
            //}

            //Child myChild = new Child(2, 3, 4);
            //Parent myParent = myChild;

            //Console.WriteLine(myChild.Product());  // Output: 24
            //Console.WriteLine(myParent.Product()); // Output: 6

            //// If Product was marked 'override' in Child
            //Console.WriteLine(myChild.Product());  // Output: 24
            //Console.WriteLine(myParent.Product()); // Output: 24

            #endregion

            #region Problem05

            //public class Parent
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }

            //    public Parent(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }


            //    public override string ToString()
            //    {
            //        return $"({X}, {Y})";
            //    }
            //}

            //public class Child : Parent
            //{
            //    public int Z { get; set; }

            //    public Child(int x, int y, int z) : base(x, y)
            //    {
            //        Z = z;
            //    }

            //    public override string ToString()
            //    {
            //        return $"({X}, {Y}, {Z})";
            //    }
            //}


            //class Prog
            //{
            //    static void Main()
            //    {
            //        Parent p = new Parent(5, 10);
            //        Child c = new Child(1, 2, 3);

            //        Parent polymorphicChild = new Child(100, 200, 300);

            //        Console.WriteLine("Parent instance: " + p.ToString());
            //        Console.WriteLine("Child instance:  " + c.ToString());
            //        Console.WriteLine("Polymorphic:     " + polymorphicChild.ToString());
            //    }
            //}

            #endregion

            #region Problem06

            //public interface IShape
            //{

            //    double Area { get; }

            //    void Draw();
            //}


            //public class Rectangle : IShape
            //{
            //    public double Width { get; set; }
            //    public double Height { get; set; }

            //    public Rectangle(double width, double height)
            //    {
            //        Width = width;
            //        Height = height;
            //    }


            //    public double Area
            //    {
            //        get { return Width * Height; }
            //    }


            //    public void Draw()
            //    {
            //        Console.WriteLine($"Drawing a Rectangle with Width: {Width} and Height: {Height}");
            //    }
            //}


            //class Prog
            //{
            //    static void Main()
            //    {

            //        Rectangle rect = new Rectangle(5, 10);


            //        IShape shape = new Rectangle(4, 7);

            //        Console.WriteLine("Testing Rectangle:");
            //        rect.Draw();
            //        Console.WriteLine($"Rectangle Area: {rect.Area}");

            //        Console.WriteLine("\nTesting via IShape reference:");
            //        shape.Draw();
            //        Console.WriteLine($"Shape Area: {shape.Area}");
            //    }
            //}

            #endregion

            #region Problem07

            //public interface IShape
            //{
            //    double Area { get; }
            //    void Draw();


            //    public void PrintDetails()
            //    {
            //        Console.WriteLine($"Shape Details: This shape has an area of {Area:F2}");
            //    }
            //}

            //public class Circle : IShape
            //{
            //    public double Radius { get; set; }
            //    private const double PI = 3.14159;

            //    public Circle(double radius)
            //    {
            //        Radius = radius;
            //    }

            //    public double Area => PI * Radius * Radius;

            //    public void Draw()
            //    {
            //        Console.WriteLine($"Drawing a Circle with radius: {Radius}");
            //    }
            //}


            //class Prog
            //{
            //    static void Main()
            //    {
            //        Circle myCircle = new Circle(5.0);


            //        IShape shape = myCircle;
            //        shape.Draw();
            //        shape.PrintDetails();
            //    }
            //}

            #endregion

            #region Problem08

            //public interface IMovable
            //{
            //    void Move();
            //}

            //public class Car : IMovable
            //{
            //    public string Model { get; set; }

            //    public Car(string model)
            //    {
            //        Model = model;
            //    }


            //    public void Move()
            //    {
            //        Console.WriteLine($"The {Model} is now driving down the road.");
            //    }
            //}

            //class Prog
            //{
            //    static void Main()
            //    {

            //        Car myTesla = new Car("Model S");

            //        IMovable movableObject = myTesla;

            //        Console.WriteLine("Calling Move via IMovable reference:");
            //        movableObject.Move();
            //    }
            //}

            #endregion

            #region Problem09

            //public interface IReadable
            //{
            //    void Read();
            //}

            //public interface IWritable
            //{
            //    void Write(string content);
            //}

            //public class File : IReadable, IWritable
            //{
            //    public string FileName { get; set; }
            //    private string _internalContent = "Empty";

            //    public File(string name)
            //    {
            //        FileName = name;
            //    }

            //    public void Read()
            //    {
            //        Console.WriteLine($"Reading from {FileName}: {_internalContent}");
            //    }

            //    public void Write(string content)
            //    {
            //        _internalContent = content;
            //        Console.WriteLine($"Successfully wrote to {FileName}.");
            //    }
            //}

            //class Prog
            //{
            //    static void Main()
            //    {
            //        File document = new File("Data.txt");

            //        document.Write("Hello World!");
            //        document.Read();

            //        IWritable writer = document;
            //        writer.Write("Updating content via writer reference.");

            //        IReadable reader = document;
            //        reader.Read();
            //    }
            //}

            #endregion

            #region Problem10

                //public abstract class Shape
                //{
                //    public virtual void Draw()
                //    {
                //        Console.WriteLine("Drawing Shape");
                //    }

                //    public abstract double CalculateArea();
                //}


                //public class Rectangle : Shape
                //{
                //    public double Width { get; set; }
                //    public double Height { get; set; }

                //    public Rectangle(double width, double height)
                //    {
                //        Width = width;
                //        Height = height;
                //    }

                //    public override void Draw()
                //    {
                //        Console.WriteLine($"Drawing a Rectangle with dimensions {Width}x{Height}");
                //    }

                //    public override double CalculateArea()
                //    {
                //        return Width * Height;
                //    }
                //}


                //class Prog
                //{
                //    static void Main()
                //    {
                //        Rectangle rect = new Rectangle(5.0, 10.0);

                //        rect.Draw();

                //        double area = rect.CalculateArea();
                //        Console.WriteLine($"The area of the rectangle is: {area}");

                //        Shape polymorphicShape = new Rectangle(4, 3);
                //        polymorphicShape.Draw();
                //    }
                //}

        #endregion
        }
    }
}
