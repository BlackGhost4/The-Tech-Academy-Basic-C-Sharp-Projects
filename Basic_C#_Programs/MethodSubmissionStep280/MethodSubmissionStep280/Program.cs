using System;

namespace MethodSubmissionStep280
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class "MathOperation" is instantiated
                MathOperation mathOperation = new MathOperation();
                //The user is asked to enter an whole number
                Console.WriteLine("Please, type a whole number");
                //The entered data is stored in the variable "numberA"
                int numberA = Convert.ToInt32(Console.ReadLine());
                //The user is asked to enter a second whole number, if he don't want to enter number must press enter key
                Console.WriteLine("Please, type a second whole number...if you don't want to enter a number, just press the enter key");
                //The entered data is stored in the variable "auxNumberB"
                //This variable will help us for know if he entered a valid number, press the enter key or type another value (for example a string)
                string auxNumberB = Console.ReadLine();
                //The variable "numberB" will store the valid number typed by the user
                int numberB;
                //Try parse the value of auxNumberB to Int
                if (!int.TryParse(auxNumberB, out numberB))
                {
                    //If the data could not be passed
                    //First it is verified that it has some data (the value does not matter),
                    //since it follows that I enter a string, character or any other that is not an integer
                    if (auxNumberB.Length > 0)
                    {
                        //If is true, an exception is thrown with an error message
                        throw new FormatException("If you don\'t want to write the second whole number, please press the enter key; you entered another data that cannot be converted to integer");
                    }
                    else
                    {
                        //If false, it follows that the user press the enter key
                        //The method "Multiplication" is called, passing only the value of the variable A
                        Console.WriteLine("\nThe mathematical operation " + numberA + " * 4 = " + mathOperation.Multiplication(numberA));
                    }
                }
                else
                {
                    //If the value entered by the user could be converted to an integer,
                    //the method "Multiplication" is sent with the values of the variables "numberA" and "numberB"
                    Console.WriteLine("\nThe mathematical operation " + numberA + " * " + numberB + " = " + mathOperation.Multiplication(numberA, numberB));
                }
            }
            //If there is an exception, it is caught by the program, even the exception that was created if
            //the user did not enter a valid data for the second number
            catch (Exception e)
            {
                Console.WriteLine("\nError!!!! -> " + e.Message);
            }
            finally
            {
                //Wait until the user press the enter key
                Console.ReadLine();
            }
        }
    }
}
