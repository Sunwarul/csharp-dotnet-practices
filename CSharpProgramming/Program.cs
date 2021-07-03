using System;
using CSharpProgramming.Loops;

namespace LearnCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter value of x: ");
            int x = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine($"Square of x is: {x * x}");
        }
    }
}
