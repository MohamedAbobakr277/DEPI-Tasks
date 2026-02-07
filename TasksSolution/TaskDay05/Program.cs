using System;
using System.Linq;

namespace TaskDay05
{
    class Program
    {
        static void Main()
        {
            //Part1

            #region Problem01

            //int x, y;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter first Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out x) || x < 0);
            //do
            //{
            //    Console.Write("Enter Second Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out y) || y < 0);

            //try
            //{
            //    int d = x / y;
            //    Console.WriteLine($"x / y = {d}");

            //}
            //catch (Exception ex) {
            //    Console.WriteLine("Divided by zero");
            //} finally {
            //    Console.WriteLine("Operation Complete"); 
            //}


            /*
             * the purpose of finally block is deallocate Resource(Unmanaged Resources)
             */

            #endregion

            #region Problem02

            //public static void TestDefensiveCode()
            //{
            //int X, Y, Z;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter first Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
            //do
            //{
            //    Console.Write("Enter Second Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            //Z = X / Y;
            //Console.WriteLine(Z);

            //int[] arr = { 1, 2, 3 };
            //if (arr?.Length > 69)
            //    arr[69] = 90;
            //}


            /*
             * int.Parse() is It assumes the string is a valid integer.
             * If it isn't, it throws a FormatException or an OverflowException if the number is too big.
             * This stops the program execution unless.
             * int.TryParse() Instead of crashing, it returns a bool (true if successful, false if not).
             * It uses an out parameter to return the actual number if the conversion works
             * 
             * int.TryParse() improves robustness because it forces the developer to acknowledge the possibility
               of failure. By returning a boolean, it encourages you to write an else path to handle invalid data,
               ensuring your application remains stable under unpredictable conditions
            */

            #endregion

            #region Problem03

            //int? x = 10;

            //int? y = x ?? default;

            /*
             * HasValue: A safety check. It returns true if the variable contains a value,
               and false if it is null.
               Value: Retrieves the actual data stored in the variable.


               If you call .Value on a variable that is currently null,
               the program will throw an InvalidOperationException and crash.
             */

            #endregion

            #region Problem04

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //try
            //{
            //    int num = numbers[5];

            //    Console.WriteLine($"num = {num}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: You tried to access an index outside the array's limits.");
            //}

            /*
             * it is necessary to check array bounds before accessing elements
             * to Preventing Runtime Crashes by writing DefensiveCode
            */

            #endregion

            #region Problem05

            //int[,] matrix = new int[3, 3];

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        bool isValid = false;
            //        while (!isValid)
            //        {
            //            Console.Write($"Element [{i},{j}]: ");
            //            if (int.TryParse(Console.ReadLine(), out int value))
            //            {
            //                matrix[i, j] = value;
            //                isValid = true;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input");
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Row {i + 1}: {rowSum}");
            //}

            //for (int j = 0; j < matrix.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Column {j + 1}: {colSum}");
            //}

            /*
             * matrix.GetLength(0) --> it gives numbers of rows
             * matrix.GetLength(1) --> it gives numbers of columns
             */

            #endregion

            #region Problem06

            //int[][] arr = new int[3][];

            //arr[0] = new int[2];
            //arr[1] = new int[4];
            //arr[2] = new int[3];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        bool isValid = false;
            //        while (!isValid)
            //        {
            //            Console.Write($"Enter value for Row {i}, Column {j}: ");
            //            if (int.TryParse(Console.ReadLine(), out int result))
            //            {
            //                arr[i][j] = result;
            //                isValid = true;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid input");
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Row {i}: ");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Problem07

            //string? str;
            //str = Console.ReadLine()!;

            /*
             * the purpose of nullable reference is about compiler enhancement
            // 1- Business purpose
            // 2- warning to avoid null ref exception 
             */

            #endregion

            #region Problem08

            //int num = 123;

            //object boxedNum = num;

            //try
            //{

            //    int unboxedNumber = (int)boxedNum;
            //    double invalidUnbox = (double)boxedNum;
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("Error: Invalid unboxing");
            //    Console.WriteLine($"Message: {ex.Message}");
            //}

            #endregion

            #region Problem09

            //int Sum;
            //int Product;

            //SumAndMultiply(10, 5, out Sum, out Product);

            //Console.WriteLine($"Sum: {Sum}");
            //Console.WriteLine($"Product: {Product}");


            //static void SumAndMultiply(int a, int b, out int sum, out int product)
            //{
            //    sum = a + b;
            //    product = a * b;
            //}


            #endregion

            #region Problem10
            //RepeatMessage("Hello!");

            //RepeatMessage("HI!", 2);

            //RepeatMessage(count: 3, message: "Named Argument");


            //static void RepeatMessage(string message, int count = 5)
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.WriteLine($"{i + 1}: {message}");
            //    }
            //}

            #endregion

            #region Problem11

            //int[]? numbers = null;

            //int? length = numbers?.Length;

            //numbers = new int[] { 10, 20, 30, 40, 50 };

            //length = numbers?.Length;
            //Console.WriteLine($"Array length: {length}");

            //int? firstElement = numbers?[0];
            //Console.WriteLine($"First element: {firstElement}");

            #endregion

            #region Problem12

            //Console.Write("Enter a day of the week: ");
            //string input = Console.ReadLine();


            //switch (input)
            //{
            //    case "monday":
            //        Console.WriteLine("Day number: 1");
            //        break;
            //    case "tuesday":
            //        Console.WriteLine("Day number: 2");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("Day number: 3");
            //        break;
            //    case "thursday":
            //        Console.WriteLine("Day number: 4");
            //        break;
            //    case "friday":
            //        Console.WriteLine("Day number: 5");
            //        break;
            //    case "saturday":
            //        Console.WriteLine("Day number: 6");
            //        break;
            //    case "sunday":
            //        Console.WriteLine("Day number: 7");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day entered.");
            //        break;
            //}

            #endregion

            #region Problem13

            //int sum1 = SumArray(10, 20, 30, 40);
            //Console.WriteLine($"Sum of individual values (10, 20, 30, 40): {sum1}");

            //int[] myNumbers = { 5, 5, 5 };
            //int sum2 = SumArray(myNumbers);
            //Console.WriteLine($"Sum of an array {5,5, 5}: {sum2}");

            //Console.WriteLine($"Sum of nothing: {SumArray()}");

            //static int SumArray(params int[] numbers)
            //{
            //    int total = 0;
            //    foreach (int n in numbers)
            //    {
            //        total += n;
            //    }
            //    return total;
            //}

            #endregion

            //Part2

            #region Problem01

            //Console.Write("Input: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + (i == n ? "" : ", "));
            //}

            #endregion

            #region Problem02

            //Console.Write("Input: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write((num * i) + (i == 12 ? "" : ", "));
            //}

            #endregion

            #region Problem03

            //Console.Write("Input: ");
            //int limit = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= limit; i += 2)
            //{
            //    Console.Write(i + (i >= limit - 1 ? "" : ", "));
            //}

            #endregion

            #region Problem04

            //Console.Write("Enter base: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Enter exponent: ");
            //int e = int.Parse(Console.ReadLine());

            //long result = 1;
            //for (int i = 0; i < e; i++)
            //{
            //    result *= b;
            //}
            //Console.WriteLine("Output: " + result);

            #endregion

            #region Problem05

            //Console.Write("Input: ");
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}

            #endregion

            #region Problem06

            //Console.Write("Input: ");
            //int val = int.Parse(Console.ReadLine());
            //int reverse = 0;

            //while (val > 0)
            //{
            //    reverse = (reverse * 10) + (val % 10);
            //    val /= 10;
            //}
            //Console.WriteLine("Output: " + reverse);

            #endregion

            #region Problem07

            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDist = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int dist = j - i - 1;
            //            if (dist > maxDist) maxDist = dist;
            //        }
            //    }
            //}
            //Console.WriteLine("Longest distance: " + maxDist);

            #endregion

            #region Problem08

                //Console.Write("Input: ");
                //string sentence = Console.ReadLine();

                //string[] words = sentence.Split(' ');

                //string result = "";

                //for (int i = words.Length - 1; i >= 0; i--)
                //{
                //    result += words[i] + " ";
                //}

                //Console.WriteLine(result.Trim());

            #endregion
        }
    }
}
