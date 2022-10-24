using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System;
using System.Runtime.InteropServices;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a method that will print to the console all numbers 1000 through -1000.
            PrintDecrement(1000, -1000);


            // 2. Write a method that will print to the console numbers 3 through 999 by 3 each time.
            PrintIncrement(3, 999, 3);

            // 3. Write a method to accept two integers as parameters and check whether they are equal or not.
            Console.WriteLine();
            Console.WriteLine(AreEqual(7, 67));
            Console.WriteLine(AreEqual(7, 7));
            Console.WriteLine(AreEqual(9, -8));



            // 4. Write a method to check whether a given number is even or odd.
            Console.WriteLine();
            Console.WriteLine(IsOddOrEven(0));
            Console.WriteLine(IsOddOrEven(5));
            Console.WriteLine(IsOddOrEven(44));
            Console.WriteLine(IsOddOrEven(-78));

            // 5. Write a method to check whether a given number is positive or negative.
            Console.WriteLine();
            Console.WriteLine(IsPositiveOrNegative(-78));
            Console.WriteLine(IsPositiveOrNegative(0));
            Console.WriteLine(IsPositiveOrNegative(22));


            // 6. Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
            Console.WriteLine();
            Console.Write("Enter your Age: ");
            string input = Console.ReadLine(); 
            int result = Int32.Parse(input);
            Console.WriteLine($"{input} is legal = {isLegal(result)}");
        }
        public static bool isLegal(int age)
        {
            return age > 18;
        }



        public static string IsOddOrEven(int num) 
        {
            string retval = "Odd";
            if (num % 2 == 0)
                retval = "Even";
            return retval;
        }

        public static string IsPositiveOrNegative(int num) 
        {
            string retval = "Positive";
            if (num < 0)
                retval = "Negative";
            if (num == 0)
                retval = "Zero";
            return retval;
        }


        public static bool AreEqual(int left, int right) 
        {
            return left == right;
        }

        public static void PrintDecrement(int left, int right)
        {
            while (left >= right)
            {
                Console.WriteLine(left);
                left--;
            }
        }

        public static void PrintIncrement(int left, int right, int increment)
        {
            while (left <= right)
            {
                Console.WriteLine(left);
                left = left + increment;
            }
        }
    }
}
