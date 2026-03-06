using System;

namespace TaskDay06
{
    class Program
    {
        static void Main()
        {

            //Part01

            #region Problem1

            //internal struct Point
            //{
            //    public int x;
            //    public int y;

            //    public Point(int _X, int _Y)
            //    {
            //        x = _X;
            //        y = _Y;
            //    }

            //    public Point(int Num)
            //    {
            //        x = y = Num;
            //    }

            //    public override string ToString()
            //    {
            //        return $" {x}, {y}";
            //    }
            //}

            /*
             * Because Classes live on the Heap. When you inherit,
             * the runtime handles the object's complexity through pointers.
             * Structs usually live on the Stack (or are embedded directly within the object that contains them).
             * To support inheritance, every instance of a struct would need a virtual method table 
             * pointer to keep track of which overridden methods to call
             */

            #endregion

            #region Problem2

            //public class TypeA
            //{
            //    private int F = 1;
            //    internal int G = 2;
            //    public int H = 3;
            //}

            //public void InternalAccess()
            //{
            //    Console.WriteLine($"Accessing from inside TypeA: F={F}, G={G}, H={H}");
            //}


            //class Prog
            //{
            //    static void Main()
            //    {
            //        TypeA obj = new TypeA();


            //        Console.WriteLine($"H: {obj.H}");
            //        Console.WriteLine($"G: {obj.G}");

            //        obj.InternalAccess();
            //    }
            //}

            /*
             * Access modifiers create "layers" of protection.
             * If you were to move TypeA into a separate Library Project,
             * the behavior changes for the internal attribute.
             * Modifier  Inside Class  Same Project  External Project
                private  Yes           No            No
                internal Yes           Yes           No
                public   Yes           Yes           Yes
             */

            #endregion

            #region Problem3

            //public struct Employee
            //{

            //    private int empId;
            //    private string name;
            //    private double salary;


            //    public Employee(int id, string name, double salary)
            //    {
            //        this.empId = id;
            //        this.name = name;
            //        this.salary = salary;
            //    }


            //    public string GetName()
            //    {
            //        return name;
            //    }

            //    public void SetName(string newName)
            //    {

            //            name = newName;
            //    }


            //    public int EmpId
            //    {
            //        get { return empId; }
            //        private set { empId = value; }
            //    }

            //    public double Salary
            //    {
            //        get { return salary; }
            //        set
            //        {
            //            if (value >= 0) salary = value;
            //        }
            //    }
            //}

            //class Prog
            //{
            //    static void Main()
            //    {

            //        Employee emp = new Employee(1, "Ali", 50000.00);


            //        Console.WriteLine($"Employee ID: {emp.EmpId}");


            //        emp.SetName("Omar");
            //        Console.WriteLine($"Updated Name: {emp.GetName()}");


            //        emp.Salary = 55000.50;
            //        Console.WriteLine($"New Salary: ${emp.Salary}");
            //    }
            //}

            /*
             * 1- Without encapsulation, any part of a program can reach into an object and change its values.
             * This often leads to an "invalid state."
             * 2- Encapsulation allows you to hide the "how" and only show the "what.".
             */

            #endregion

            #region Program4

            //public struct Point
            //{
            //    public int X;
            //    public int Y;


            //    public Point(int xValue)
            //    {
            //        X = xValue;
            //        Y = 0;
            //    }


            //    public Point(int xValue, int yValue)
            //    {
            //        X = xValue;
            //        Y = yValue;
            //    }

            //    public void Print()
            //    {
            //        Console.WriteLine($"Point: ({X}, {Y})");
            //    }
            //}


            //class Prog
            //{
            //    static void Main()
            //    {

            //        Point p1 = new Point(10);
            //        Console.Write("Using p1(x): ");
            //        p1.Print();


            //        Point p2 = new Point(25, 40);
            //        Console.Write("Using p2(x, y): ");
            //        p2.Print();


            //        Point p3 = new Point();
            //        Console.Write("Using default(): ");
            //        p3.Print();
            //    }
            //}

            /*
             * a constructor in a struct is a special method used to initialize
             * the fields of the struct when an instance is created.
             */

            #endregion

            #region Problem5

            //public struct Point
            //{
            //    public int X;
            //    public int Y;

            //    public Point(int x, int y)
            //    {
            //        X = x;
            //        Y = y;
            //    }


            //    public override string ToString()
            //    {
            //        return $"Point Coordinates: [X = {X}, Y = {Y}]";
            //    }
            //}


            //class Prog
            //{
            //    static void Main()
            //    {

            //        Point p1 = new Point(5, 10);
            //        Point p2 = new Point(-3, 7);
            //        Point p3 = new Point(100, 200);


            //        Console.WriteLine(p1);
            //        Console.WriteLine(p2);
            //        Console.WriteLine(p3);
            //    }
            //}


            /*
             * By overriding ToString() inside the struct or class,
             * you define the "string logic" in one place.
             * You don't have to write messy formatting logic everywhere you print.
             */
            #endregion

            #region Problem6


            //public struct Point
            //{
            //    public int X;
            //    public Point(int x)
            //    {
            //        this.X = x;
            //    }
            //}

            //public class Employee
            //{
            //    public string Name;
            //    public Employee(string name)
            //    {
            //        this.Name = name;
            //    }
            //}

            //class Prog
            //{
            //    static void ModifyValueType(Point p)
            //    {
            //        p.X = 99;
            //    }

            //    static void ModifyReferenceType(Employee e)
            //    {
            //        e.Name = "Abobakr";
            //    }
            //    static void Main()
            //    {

            //        Point myPoint = new Point(10);
            //        Employee myEmp = new Employee("Mohamed");

            //        Console.WriteLine($"Point X: {myPoint.X}");
            //        Console.WriteLine($"Employee Name: {myEmp.Name}");

            //        ModifyValueType(myPoint);
            //        ModifyReferenceType(myEmp);


            //        Console.WriteLine($"Point X: {myPoint.X}");
            //        Console.WriteLine($"Employee Name: {myEmp.Name}");
            //    }

            //}


            /*
             * Structs are Value Types. When you declare a struct, the memory is usually allocated on the Stack.
             * The memory for the struct contains the actual data of the fields.
             * Memory on the stack is "self-cleaning." When a method finishes execution,
             * its stack frame is popped, and the memory used by the struct is immediately reclaimed.
             * Because the stack manages itself, structs do not put pressure on the Garbage Collector.
             * 
             * Classes are Reference Types. When you create a class instance, the allocation is split into two parts:
             * The Header (Stack): A small variable on the stack holds memory address.
             * The Body (Heap): The actual data is allocated on the Managed Heap.
             * When the variable on the stack goes out of scope,
             * the data on the heap remains until the Garbage Collector determines it is no longer being used and deletes it.
             */

            #endregion

        }
    }
}
