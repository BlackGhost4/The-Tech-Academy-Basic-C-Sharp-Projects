using System;

namespace ClassSubmissionStep285
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /***************************************************************************************
                 * The class ExampleClass is instantiated
                *****************************************************************************************/
                ExampleClass exampleClass = new ExampleClass();
                
                //Ask to user a number
                Console.WriteLine("Press type a whole number");
                /****************************************************************************************
                * The Next Line was comented, because the conversion from string to integer is done in a method of the class
                
                int number = Convert.ToInt32(Console.ReadLine());
                ******************************************************************************************/
                string number = Console.ReadLine();
                int numberB = 0; //For the class "ExampleClass"
                int numberC = 0; //Fot the static class "ExampleClassStatic"

                /***************************************************************************************
                 * Call the method Divide of the clas "ExampleClass" 
                ****************************************************************************************/
                exampleClass.Divide(number, out numberB); //Store the result in the variable "numberB"

                /***************************************************************************************
                 * Call the method Divide of thestatic class "ExampleClassStatic"
                ****************************************************************************************/
                ExampleClassStatic.Divide(number, out numberC); //Store the result in the variable "numberC"

                /******************************************************************************************
                Result of the Class ExampleClass
                If the value of numberB is -1, then the data entered by the user cannot divided by two
                *******************************************************************************************/
                Console.WriteLine("\nResult of the class \"ExampleClass\"");
                if (numberB == -1)
                {
                    //show the message that the number cannot divided by two
                    Console.WriteLine("The number " + number + " cannot be divided by 2");
                }
                else
                {
                    //Otherwise, print the result on the console
                    Console.WriteLine("The number " + number + " divided by 2 is equal to " + numberB);
                }

                /******************************************************************************************
                Result of the Class ExampleClassStatic
                If the value of numberB is -1, then the data entered by the user cannot divided by two
                *******************************************************************************************/
                Console.WriteLine("\nResult of the static class \"ExampleClassStatic\"");
                if (numberC == -1)
                {
                    //show the message that the number cannot divided by two
                    Console.WriteLine("The number " + number + " cannot be divided by 2");
                }
                else
                {
                    //Otherwise, print the result on the console
                    Console.WriteLine("The number " + number + " divided by 2 is equal to " + numberC);
                }
            }
            //If exist an exception, is catched and print the error message on the console
            catch (Exception e)
            {
                Console.WriteLine("Error!!!! -> " + e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
