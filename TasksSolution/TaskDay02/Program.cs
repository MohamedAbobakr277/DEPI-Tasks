using System;

namespace TaskDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part01

            #region problem1

            /*
             * This program performs a simple arithmetic operation, It initializes two integer variables,
             * calculates their sum, and outputs the result to the console.
             */

            int x = 10;         // Initialize variable x with 10
            int y = 20;         // Initialize variable y with 20
            int sum = x + y;        // Calculate the sum of x and y and store it in variable sum
            Console.WriteLine(sum);         // print the variable sum


            // shortcut to comment: ctrl + k + c
            // shortcut to uncomment: ctrl + k + u 

            #endregion


            #region problem2

            int x = "10";       // The value isn`t match data type
            console.WriteLine(x + y);       // Csharp is case sensitive so console is not exist

            /*
                A Runtime Error: happens while the program is running.
                The code has no syntax mistakes, so it compiles successfully,
                but the computer encounters an operation it cannot perform during execution,
                causing the program to crash.

                Example: Dividing by zero, trying to access an index that doesn't exist in an array.

                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
             */


            /*
                A Logical Error: The program runs perfectly without crashing,
                but it produces the wrong result or behaves incorrectly.

                Example: Using the wrong formula, mistakes in order of operations issues.

                int width = 5;
                int height = 10;

                int area = width + height; 
                Console.WriteLine("The area is: " + area);
             */

            #endregion


            #region problem3

            string FullName;
            int Age;
            decimal MonthlySalary;
            bool IsStudent;

            /*
                 Following standard naming conventions like PascalCase in C#
                 it is a critical part of writing professional, maintainable software.
                 In the .NET ecosystem, these conventions are effectively the "grammar" of the language.

                1- Consistency Across the Ecosystem:
                C# is unique because Microsoft provides very strict guidelines.
                The entire .NET framework (from Console.WriteLine to List<T>.Add) uses PascalCase for public members.
                If we write console.writeLine() or list.add(),
                it feels jarring to other C# developers.

                2- Avoiding Mental Friction in Teams:
                In large projects or team environments, we spend more time reading code than writing it.
                If every developer invents their own style (e.g., user_name vs UserName vs userName),
                the brain has to work harder to parse the code.
                Standard conventions remove this friction,
                allowing the team to focus on the logic rather than the formatting.
           
             */

            #endregion


            #region problem4

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = numbers1;

            numbers2[0] = 99;
            Console.WriteLine(numbers1[0]);

            /*
                Value Types:
                They are stored directly on the Stack, and the variable holds the actual data.
                so when we assign x = y, the computer makes a photocopy of the value.
                If you change the copy, the original is untouched.
             */


            /*
                Reference Types:
                Their storage is split into two parts:
                The Reference (The Address): Stored on the Stack.
                The Object (The Data): Stored on the Heap.
                The variable on the Stack does not hold the data; it holds a memory address
                that points to where the data actually lives on the Heap.
             */

            #endregion


            #region problem5

            int x = 15;
            int y = 4;

            int Sum = x + y;
            int Difference = x - y;
            int Product = x * y;
            int Division = x / y;
            int Remainder = x % y;


            int a = 2, b = 7;
            Console.WriteLine(a % b);   // the output is 2 becouse 7 goes into 2 zero times (7 times 0 = 0).
                                        // The amount left over (the remainder) is 2.

            #endregion


            #region problem6

            int number = 12;

            if (number > 10 && number % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even");
            }
            else
            {
                Console.WriteLine("The number does not meet both conditions.");
            }


            /*
                The && Operator (Logical AND):
                It uses Short-Circuit Evaluation.
                If the first condition is false, it stops immediately.
                It does not even look at the second condition
                because the final result is already guaranteed to be false.
            */


            /*
                The & Operator (Bitwise AND):
                It checks both sides every single time, no matter what.
                It evaluates the first condition AND the second condition, even if the first one was already false.
                it is uses for integers that It compares the individual bits (1s and 0s) of two numbers.
             */

            #endregion


            #region problem7

            double num = double.Parse(Console.ReadLine());

            int ExplicitInt = (int)num;
            int ImplicitInt = num;

            Console.WriteLine(ExplicitInt);
            Console.WriteLine(ImplicitInt);


            /*
             * Explicit casting is required because converting a double to an int is a Narrowing Conversion (not safe).
             * This means you are moving data from a type capable of holding more information (fractions and huge numbers)
             * to a type capable of holding less.
             */

            #endregion


            #region problem8

            string AgeInput = Console.ReadLine();

            int age = int.Parse(AgeInput);

            if (age > 0)
            {
                Console.WriteLine("the age is valid");
            }
            else
            {
                Console.WriteLine("this age is not valid");
            }


            /*
                When using int.Parse() to convert user input,
                we will primarily encounter two types of Runtime Exceptions if the input is invalid.
                FormatException: The input string is not in the correct format.
                OverflowException: The input is a valid number,
                but it is too large or too small for an int to hold.

                we can handle it using try-catch Block
             */

            #endregion


            #region problem9

            int X = 10;

            Console.WriteLine(X); // Output: 10


            Console.WriteLine(X++); // output: 10
            Console.WriteLine(X); //output: 11


            X = 10;

            Console.WriteLine(++X); // output: 11
            Console.WriteLine(X); // output: 11



            int x = 5;
            int y = ++x + x++;

            // The value of x after execution is 7
            // first we will increment x so x = 6 
            // and then we will decrement x so x = 7


            #endregion

        }
    }
}
