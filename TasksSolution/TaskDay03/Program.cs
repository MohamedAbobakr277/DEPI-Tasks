using System;

namespace TaskDay03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part01


            #region Problem1

            string input = Console.ReadLine();

            // 1- Using int.Parse
            try
            {
                int num = int.Parse(input);
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in a correct numeric format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small for an Int32");
            }

            // 2- Using Convert.ToInt32
            try
            {
                int num = Convert.ToInt32(input);
                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not in a correct numeric format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small for an Int32");
            }



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



                string s = Console.ReadLine();

                if (int.TryParse(s, out int number))
                {
                    Console.WriteLine($"You entered the integer: {number}");
                }
                else
                {
                    Console.WriteLine("That is not a valid integer.");
                }
            }
        }
    }
    }
}
