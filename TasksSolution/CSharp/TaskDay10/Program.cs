using System;

namespace TaskDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part01

            #region Problem01

            //class Employee : IComparable<Employee>
            //{
            //    public int Id { get; set; }
            //    public string Name { get; set; }
            //    public double Salary { get; set; }

            //    public Employee(int _id, string _name, double _salary)
            //    {
            //        Id = _id;
            //        Name = _name;
            //        Salary = _salary;
            //    }

            //    public override string ToString()
            //    {
            //        return $"Id is {Id}, Name is {Name}, Salary is {Salary}";
            //    }

            //    public int CompareTo(Employee other)
            //    {
            //        return this.Salary.CompareTo(other.Salary);
            //    }
            //}

            //class SortingAlgorithm<T> where T : IComparable<T>
            //{
            //    public static void Sort(T[] items)
            //    {
            //        for (int i = 0; i < items.Length - 1; i++)
            //        {
            //            for (int j = 0; j < items.Length - 1 - i; j++)
            //            {
            //                if (items[j].CompareTo(items[j + 1]) == 1)
            //                {
            //                    Swap(ref items[j], ref items[j + 1]);
            //                }
            //            }
            //        }
            //    }

            //    public static void Swap(ref T a, ref T b)
            //    {
            //        T temp = a;
            //        a = b;
            //        b = temp;
            //    }
            //}

            //Employee[] Emps =
            //{
            //    new Employee(1,"Ali",1000),
            //    new Employee(2,"omar",400),
            //    new Employee(3,"mohamed",700)
            //};
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(Emps);
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            #endregion

        }
    }
}