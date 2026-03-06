using System;

namespace TaskDay04
{
    class Program
    {
        static void Main()
        {
            //Part01

            #region Problem01

            //int[] arr = new int[10];
            //int[] arr2 = new int[] { 0, 0, 0,0,0,0,0,0,0,0 };
            //int[] arr3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i+1;
            //}

            //Console.WriteLine(arr[15]); //IndexOutOfRangeException
            //// index 15 is outside the bounds of the array.


            /*
             * the default value assigned to array elements
             * depends on the data type of the array
             * int, byte, long, short --> 0
             * float, double, decimal --> 0.0
             * bool --> false
             * string, class, object --> null
             */

            #endregion


            #region Problem02

            //int[] arr1 = new int[4] {1,2,3,4};
            //int[] arr2 = new int[4] {5,6,7,8};

            ////arr2 = arr1;
            ////arr2[0] = 20;
            ////Console.WriteLine(arr1[0]); //20

            //arr2 = (int[]) arr1.Clone();
            //Console.WriteLine(arr1[0]);//1
            //Console.WriteLine(arr2[0]);//1

            //arr2[0] = 20;

            //Console.WriteLine(arr1[0]);//1
            //Console.WriteLine(arr2[0]);//20


            /*
             * the difference lies in how they create the destination array 
             * and the scope of the copy
             * Array.Clone(): Creates a new array object automatically.
             * Array.Copy(): Requires an existing destination array.
             */

            #endregion


            #region Problem03

            //int[,] grades = new int[3, 3];

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        bool flag = int.TryParse(Console.ReadLine(), out grades[i, j]);
            //    }
            //}

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write(grades[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*
             * The Length returns the total number of elements across all dimensions of the array.
             * The GetLength() method returns the number of elements in a specific dimension (rank).
             * Since rectangular arrays in C# are zero-indexed, the first dimension is 0, the second is 1, and so on.
             */

            #endregion


            #region Problem04

            //int[] arr = new int[] { 2, 5, 8, 1, 0, 9 };
            //int[] arr2 = new int[6];
            //Array.Sort(arr); // sort the arr
            //Array.Reverse(arr); // reverse the arr
            //Console.WriteLine(Array.IndexOf(arr, 1)); // find the index of an element in the arr
            //Array.Copy(arr, arr2, 6);

            //foreach (int i in arr2) Console.WriteLine(i);
            //Array.Clear(arr,2,3);
            //foreach (int i in arr) Console.WriteLine(i);


            #endregion


            #region Problem05


            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// 1. For loop:

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //// 2. Foreach loop:
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //// 3. While loop:
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;
            //}


            /*
             * Safety and Index Out of Bounds: The compiler handles the boundaries.
             * It is mathematically impossible to trigger an IndexOutOfRangeException
             * using a foreach loop because the iteration logic is abstracted.
             * Using foreach clearly signals your intent to someone reading your code.
             */

            #endregion


            #region Problem06

            //bool flag;
            //int num;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (flag == false || num % 2 == 0 || num < 0); 


            /*
             * To Preventing Application Crashes 
             * and to make Logic and Data Consistency
             */

            #endregion


            #region Problem07

            //int[,] arr = new int[3, 3] { {1,2,3 }, {4,5,6 }, {7,8,9 } };

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region Problem08

            //Console.Write("Enter a month number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int monthNum))
            //{
            //    // 1. Using If-Else Statement
            //    string month;
            //    if (monthNum == 1) month = "January";
            //    else if (monthNum == 2) month = "February";
            //    else if (monthNum == 3) month = "March";
            //    else if (monthNum == 4) month = "April";
            //    else if (monthNum == 5) month = "May";
            //    else if (monthNum == 6) month = "June";
            //    else if (monthNum == 7) month = "July";
            //    else if (monthNum == 8) month = "August";
            //    else if (monthNum == 9) month = "September";
            //    else if (monthNum == 10) month = "October";
            //    else if (monthNum == 11) month = "November";
            //    else if (monthNum == 12) month = "December";
            //    else month = "Invalid month number";

            //    Console.WriteLine($"Month: {month}");

            //    // 2. Using Switch Statement
            //    string month2;
            //    switch (monthNum)
            //    {
            //        case 1:
            //            month2 = "January"; break;
            //        case 2:
            //            month2 = "February"; break;
            //        case 3:
            //            month2 = "March"; break;
            //        case 4:
            //            month2 = "April"; break;
            //        case 5:
            //            month2 = "May"; break;
            //        case 6:
            //            month2 = "June"; break;
            //        case 7:
            //            month2 = "July"; break;
            //        case 8:
            //            month2 = "August"; break;
            //        case 9:
            //            month2 = "September"; break;
            //        case 10:
            //            month2 = "October"; break;
            //        case 11:
            //            month2 = "November"; break;
            //        case 12:
            //            month2 = "December"; break;
            //        default:
            //            month2 = "Invalid month number"; break;
            //    }

            //    Console.WriteLine($"Month: {month2}");
            //}
            //else
            //{
            //    Console.WriteLine("Enter a valid numeric integer.");
            //}


            /*
             * When to Prefer switch:
                1-when we are comparing a single variable against a list of discrete, constant values.
                2-If we have more than 3 or 4 conditions, if-else starts to look cluttered. A switch is visually organized.
                3-Use it when checking integers, strings.

                When to Prefer if-else:
                1-The if-else structure is far more flexible and should be used for ranges or complex logic.
                2-If we need to check if a value is between two numbers, a switch is difficult or impossible to use.
                3-Use if-else if your conditions involve different variables.
                4-If weare calling methods or performing calculations within the check.
            */

            #endregion


            #region Problem09

            //int[] numbers = { 45, 12, 85, 32, 12, 67, 53, 12, 90 };

            //// 1. Sort the array using Array.Sort()
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i] + " ");
            //}

            //// 2. Search for a specific value
            //int firstIndex = Array.IndexOf(numbers, 12);
            //int lastIndex = Array.LastIndexOf(numbers, 12);

            //if (firstIndex != -1)
            //{
            //    Console.WriteLine($"First index of 12: {firstIndex}");
            //    Console.WriteLine($"Last index of 12: {lastIndex}");
            //}
            //else
            //{
            //    Console.WriteLine("Value not found in the array.");
            //}

            /*
             * the time complexity of Array.Sort() is O(nlogn)
             */

            #endregion


            #region Problem10

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}

            //Console.WriteLine($"Sum using for loop: {sumFor}");

            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}

            //Console.WriteLine($"Sum using foreach loop: {sumForeach}");


            /*
             * foreach : The preferred choice for readability. When used on arrays,
             * the C# compiler converts it into a for loop, so there is no performance penalty.
             */

            #endregion


            //Part02

            //enum DayOfWeek
            //{
            //    Monday = 1,
            //    Tuesday = 2,
            //    Wednesday = 3,
            //    Thursday = 4,
            //    Friday = 5,
            //    Saturday = 6,
            //    Sunday = 7
            //}

            //Console.Write("Enter a number (1-7): ");
            //string input = Console.ReadLine();

            //try
            //{
            //    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);

            //    if (Enum.IsDefined(typeof(DayOfWeek), day))
            //    {
            //        Console.WriteLine($"The day is: {day}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Please enter a number between 1 and 7.");
            //    }
            //}
            //catch (ArgumentException)
            //{
            //       Console.WriteLine("Invalid input. Please enter a valid integer.");
            //} 


            /*
             * If a user enters a number like 10, Enum.Parse will not throw an exception.
             * Instead, it will successfully return the integer 10 cast as a DayOfWeek type,
             * even though no such name exists in our definition.
                This happens because C# enums are technically just named wrappers around underlying numeric types.
                The system treats any valid integer as a valid potential value for the enum.
             */
        }
    }
}
