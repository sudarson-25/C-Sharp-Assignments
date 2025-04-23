// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joiners at Metamation, Batch - July 2024.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// C# Program to Reverse a Number and Check if it is a Palindrome
// Sudarson S
// ------------------------------------------------------------------------------------------------

using System;

namespace Assignment
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Enter a number: ");
            int num = Convert.ToInt32 (Console.ReadLine ());
            if (PallindromeChecker (num, NumberReverser (num)))
                Console.WriteLine ("Pallindrome!");
            else
                Console.WriteLine ("Not a Pallindrome!");
        }

        /// <summary>Reverses a given number</summary>
        static int NumberReverser (int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            return rev;
        }

        /// <summary>Checks if the given number is a pallindrome</summary>
        static bool PallindromeChecker (int num1, int num2)
        {
            return num1 != num2 ? false : true;
        }
    }
}