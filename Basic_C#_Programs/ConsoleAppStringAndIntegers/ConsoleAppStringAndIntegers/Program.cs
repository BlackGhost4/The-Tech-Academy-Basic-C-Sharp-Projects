using System;
using System.Collections.Generic;

namespace ConsoleAppStringAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A list of integers is created
            List<int> numbers = new List<int>() { 45, 34, 68, 23, 785, 23, 75, 234 };
            try
            {
                Console.WriteLine("Type a whole number to divide each number in a list with 8 items....");
                //For the purposes of the exercise, only whole numbers will be requested
                int number = Convert.ToInt32(Console.ReadLine());
                foreach (int auxNumber in numbers)
                {
                    //Print the result of divition on the console
                    Console.WriteLine("The number " + auxNumber + " divided by " + number + " is equal " + (auxNumber / number));
                }
            }
            //If the user don't enter a whole number
            catch (FormatException ex)
            {
                Console.WriteLine("Please a whole number");
            }
            //if the user entered a zero, an exception occurs since an integer cannot be divided by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            //This catch ocurrs, if exist another exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Wait until the user press the enter key
                Console.ReadLine();
            }
        }
    }
}
