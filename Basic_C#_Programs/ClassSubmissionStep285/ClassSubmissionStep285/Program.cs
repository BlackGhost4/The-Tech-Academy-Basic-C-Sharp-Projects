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
                 * The following line was commented, because the class was made static and the static classes are not instantiated
                
                ExampleClass exampleClass = new ExampleClass();
                *****************************************************************************************/

                Console.WriteLine("Press type a whole number");
                /****************************************************************************************
                * The Next Line was comented, because the conversion from string to integer is done in a method of the class
                
                int number = Convert.ToInt32(Console.ReadLine());
                ******************************************************************************************/
                string number = Console.ReadLine();
                int numberB = 0;

                /***************************************************************************************
                 * The following line was commented, because the class was made static 
                
                exampleClass.Divide(number, out numberB);
                ****************************************************************************************/
                ExampleClass.Divide(number, out numberB); //Call the method "Divide" of the static class "ExampleClass"
                //If the value of numberB is -1, then the data entered by the user cannot divided by two
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
