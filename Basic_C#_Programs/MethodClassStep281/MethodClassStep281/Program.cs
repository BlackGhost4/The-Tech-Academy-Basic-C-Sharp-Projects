using System;

namespace MethodClassStep281
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class "MathOperation" is instantiated
            MathOperation mathOperation = new MathOperation();
            //For purpose of this exercise, the variables numberA and numberB are created
            int numberA = 10, numberB = 0;
            //Call the method "Multiplication" with the two parameters
            mathOperation.Multiplication(numberA: numberA, numberB: out numberB);
            //The variable "numberB" will store the result of the mathematical operation
            //Print the value of "numberB" on the console
            Console.WriteLine("The mathematical operation " + numberA + " * 4 = {0}", numberB);
            Console.ReadLine();
        }
    }
}
