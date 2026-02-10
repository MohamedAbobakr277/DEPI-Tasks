using System;
using System.Linq;
using System.Text;

namespace TaskDay03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part01

            #region Problem1

            //string str = Console.ReadLine();

            //// 1- Using int.Parse
            //try
            //{
            //    int n1 = int.Parse(str);
            //    Console.WriteLine(n1);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input was not in a correct numeric format");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number is too large or too small");
            //}

            //// 2- Using Convert.ToInt32
            //try
            //{
            //    int n2 = Convert.ToInt32(str);
            //    Console.WriteLine(n2);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input was not in a correct numeric format");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number is too large or too small");
            //}

            /*
                int.Parse(string) is designed strictly for string-to-integer conversion.
                It assumes you are providing a valid string object.
                If you pass it a null reference,
                the method considers it a violation of its requirements and throws an error immediately.

                Convert.ToInt32(object) is part of a broader utility class meant to handle various data types.
                It is designed to be more forgiving or defensive.
                When it sees a null, it interprets it as an empty value and returns the default integer value, which is 0.
             */

            #endregion

            #region Problem2

            //int num;
            //if (int.TryParse(Console.ReadLine(), out num))
            //{
            //    Console.WriteLine($"The Number is: {num}");
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            /*
             * The biggest technical reason to use TryParse is performance.
             * When Parse fails, the runtime must:
             * Pause execution to find a catch block. Capture a full stack trace.
             * Allocate memory for the exception object.
             * TryParse is implemented to avoid this entirely.
             * Instead of throwing an exception, it simply returns false.
             */

            #endregion

            #region Problem3

            //object obj;

            //obj = 2;
            //Console.WriteLine(obj.GetHashCode());

            //obj = "Mohamed";
            //Console.WriteLine(obj.GetHashCode());

            //obj = 2.333;
            //Console.WriteLine(obj.GetHashCode());

            /*
             * GetHashCode() is a way to uniquely identify an object,
             * its real purpose is much more specific:
             * it acts as a "speed pass" for hash-based collections.
             */

            #endregion

            #region Problem4

            //int[] arr = { 1, 2, 3 };
            //int[] arr2 = arr;

            //arr[0] = 9;
            //Console.WriteLine(arr2[0]);

            /*
             * In .NET, Reference Equality means that
             * two variables point to the exact same memory address
             * on the managed heap. They aren't just having the same data;
             * they are the same person with two different names.
             */

            #endregion

            #region Problem5

            //string str = "Welcome";
            //Console.WriteLine(str.GetHashCode());

            //str += "Hi Willy";
            //Console.WriteLine(str.GetHashCode());

            /*
             * Because strings are immutable, the .NET runtime can use a process
             * called String Interning. If we have 1000 variables containing the word "HI"
             * .NET doesn't need to store that word 1000 times.
             * It stores it once in a the Intern Pool and points all
             * 1000 references to that single memory address.
             * 
             * Strings are often used to store sensitive data:
             * file paths, database connection strings, and network URLs.
             * If strings were mutable, an untrusted piece of code could potentially
             * change a string after it has been validated but before it is used.
             */

            #endregion

            #region Problem6

            //StringBuilder stringBuilder = new StringBuilder("Welcome");
            //Console.WriteLine(stringBuilder.GetHashCode());

            //stringBuilder.Append("Hi Willy");
            //Console.WriteLine(stringBuilder.GetHashCode());

            /*
             * When we concatenate strings using +=,
             * the runtime must create a new string object on the heap,
             * copy every single character from the old string,
             * and then add the new characters.
             * StringBuilder avoids this by pre-allocating the Capacity.
             * If you add text and it fits within the current capacity,
             * no new memory is allocated.The characters are simply written into the existing array.
             */

            #endregion

            #region Problem7

            /*
             * StringBuilder manages an internal character array with Capacity.
             * Appending: When you call .Append(), it simply writes the new characters
             * into the existing empty slots of its internal array.
             * This is a simple memory write operation.
             * Expansion: If the internal array fills up, StringBuilder doesn't just add one slot.
             * It doubles its capacity. 
             */

            #endregion

            #region Problem8

            //int n1, n2;
            //bool f1 = int.TryParse(Console.ReadLine(), out n1);
            //bool f2 = int.TryParse(Console.ReadLine(),out n2);

            //Console.WriteLine("Sum is " + n1 + " + " + n2);
            //Console.WriteLine("Sum is {0} + {1}", n1, n2);
            //Console.WriteLine($"Sum is {n1} + {n2}");

            /*
             * In modern C# development, String Interpolation (using the $ prefix)
             * is by far the most used method.
             * It is the most readable. You can see exactly where the variables fall within
             * the sentence without looking back and forth at a list of arguments.
             */

            #endregion

            #region Problem09

            //StringBuilder stringBuilder = new StringBuilder("Hi");

            //stringBuilder.Append("Mohamed");
            //stringBuilder.Replace("Hi", "NO");
            //stringBuilder.Insert(3, "Welcome ");
            //stringBuilder.Remove(0, 2);


            #endregion

        }
    }
}
