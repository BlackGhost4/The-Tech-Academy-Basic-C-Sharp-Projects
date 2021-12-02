using System;

namespace MainMethodStep279
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class MathOperation is instantiated
                MathOperation mathOperation = new MathOperation();
                //For the purposes of the exercise, three variables were created that will serve as parameters in the three methods
                int numberA = 45;
                decimal numberB = 235.23455m;
                string numberC = "23";
                //The first method is called with an integer as a parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberA + " = " + mathOperation.Addition(numberA));
                //The second method is called with a decimal as a parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberB + " = " + mathOperation.Addition(numberB));
                //The third method is called with a string as a parameter
                Console.WriteLine(mathOperation.auxNumber + " + " + numberC + " = " + mathOperation.Addition(numberC));
            }
            //If there is an error during the execution of the program, it is caught and the message is displayed on the console
            catch (Exception e)
            {
                Console.WriteLine("Error!!!! " + e.Message);
            }
            finally
            {
                //Wait until the user presses the enter key
                Console.ReadLine();
            }
        }
    }
}
