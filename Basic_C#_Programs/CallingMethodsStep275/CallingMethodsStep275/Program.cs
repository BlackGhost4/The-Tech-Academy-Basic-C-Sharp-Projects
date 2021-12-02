using System;

namespace CallingMethodsStep275
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //The program request to user a number
                Console.WriteLine("Type a number to perform three mathematical operations");
                //the data is stored in the variable number
                int number = int.Parse(Console.ReadLine());
                //Class "MathOperations" is instantiated
                MathOperations mathOperations = new MathOperations();
                //The method "Addition" is called to add the data entered with the user with the variable that helps us in the operation
                Console.WriteLine("The number " + mathOperations.numberB + " + " + number + " is equal to " + mathOperations.Addition(number));
                //The method "Subtraction" is called to subtract the data entered with the user with the variable that helps us in the operation
                Console.WriteLine("The number " + mathOperations.numberB + " - " + number + " is equal to " + mathOperations.Subtraction(number));
                //The method "Multiplication" is called to multiplicate the data entered with the user with the variable that helps us in the operation
                Console.WriteLine("The number " + mathOperations.numberB + " * " + number + " is equal to " + mathOperations.Multiplication(number));
            }
            //If there is any exception, catch that exception
            catch (Exception e)
            {
                //print a message error with the exception on the console
                Console.WriteLine("Error !!!! -> " + e.Message);
            }
            finally
            {
                //wait until user press enter key
                Console.ReadLine();
            }
        }
    }
}
