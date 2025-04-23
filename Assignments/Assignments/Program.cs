// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joiners at Metamation, Batch - July 2024.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program where the user guesses the computer generated random number.
// Sudarson S
// ------------------------------------------------------------------------------------------------

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Write ("Number Guessing Game\n~~~~~~~~~~~~~~~~~~~~\nEnter your guess: ");
            int guess, generated = GuessingGame ();
            do
            {
                guess = Convert.ToInt32 (Console.ReadLine ());
                if (generated > guess)
                    Console.WriteLine ("Your guess is too low");
                else if (generated < guess)
                    Console.WriteLine ("Your guess is too high");
            } while (guess != generated);
            if (generated == guess) Console.WriteLine ("You guessed correctly");
        }

        /// <summary>Returns a random number between the specified range</summary>
        static int GuessingGame ()
        {
            Random rand = new Random ();
            return rand.Next (1, 100);
        }
    }
}