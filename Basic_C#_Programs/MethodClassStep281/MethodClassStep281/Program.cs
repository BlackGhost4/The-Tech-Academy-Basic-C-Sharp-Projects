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
            int numberA = 10, numberB = 6;
            //Call the method in the class, passing in two numbers
            mathOperation.Multiplication(56, 23);
            //Call the method "Multiplication" with the two parameters, specifying the parameters by name
            mathOperation.Multiplication(numberA: numberA, numberB: numberB);
            Console.ReadLine();
        }
    }
}
