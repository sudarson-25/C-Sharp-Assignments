// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joiners at Metamation, Batch - July 2024.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to Print Odd Numbers in a Given Range
// Sudarson S
// ------------------------------------------------------------------------------------------------

using System;

namespace Assignments
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Enter the start of the range: ");
            int start = Convert.ToInt32 (Console.ReadLine ());
            Console.Write ("Enter the end of the range: ");
            int end = Convert.ToInt32 (Console.ReadLine ());
            for (int i = start; i <= end; i++) if (i % 2 != 0) Console.WriteLine (i);
        }
    }
}