using System;
using System.Runtime.CompilerServices;

namespace MyFirstProgrm
{
    class Program
    {
        //Swap Two Numbers
        static void Main (string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine ("Before Swap:" + a + " " + b);
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine ("After Swap:" + a + " " + b);
        }
    }
}