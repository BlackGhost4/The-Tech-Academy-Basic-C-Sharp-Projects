using System;

namespace TryCatchAssignmentStep388
{
    class Program
    {
        static void Main(string[] args)
        {
            //block try/catch for catch any exception
            try
            {
                //variable age
                int age = 0;
                //ask the user his age
                Console.WriteLine("Please enter your age");
                //store the data in variable data
                string data = Console.ReadLine();
                //try parse the data to int
                if (int.TryParse(data, out age))
                {
                    //if age is less than zero
                    if (age < 0)
                    {
                        //An AgeExceptions is thrown
                        throw new AgeExceptions("You must type a positive number");
                    }
                    else
                    {
                        //Calculate the year of born
                        Console.WriteLine("You were born in {0}", DateTime.Now.AddYears(age * -1).Year);
                    }
                }
                else
                {
                    //if it was not possible to pass the data, an Exception is thrown
                    throw new Exception("You must type a valid number");
                }
            }
            //Catch the exception of type AgeEsception
            catch (AgeExceptions e)
            {
                Console.WriteLine("Error!!!! -> {0}", e.Message);
            }
            //Catch any other exception
            catch (Exception e)
            {
                Console.WriteLine("Error!!!! -> {0}", e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
