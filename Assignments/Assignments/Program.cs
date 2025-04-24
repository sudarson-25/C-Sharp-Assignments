// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joiners at Metamation, Batch - July 2024.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to Check Whether a Given Number is Even or Odd
// Sudarson S
// ------------------------------------------------------------------------------------------------

using System;

namespace Assignments
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Enter a number: ");
            int num = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine (num % 2 == 0 ? "Even" : "Odd");
        }
    }
}