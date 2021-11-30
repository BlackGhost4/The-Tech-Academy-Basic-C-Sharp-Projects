using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 20;
            int numberB = 10;

            int sum = numberA + numberB;
            int subtraction = numberA - numberB;
            int multiplication = numberA * numberB;
            int division = numberA / numberB;

            Console.WriteLine(numberA.ToString() + " + " + numberB.ToString() + " = " + sum.ToString());
            Console.WriteLine(numberA.ToString() + " - " + numberB.ToString() + " = " + subtraction.ToString());
            Console.WriteLine(numberA.ToString() + " * " + numberB.ToString() + " = " + multiplication.ToString());
            Console.WriteLine(numberA.ToString() + " / " + numberB.ToString() + " = " + division.ToString());
            Console.ReadLine();
        }
    }
}
