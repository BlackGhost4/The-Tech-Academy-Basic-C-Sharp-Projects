using System;

namespace DateTimeSubmissionStep369
{
    class Program
    {
        static void Main(string[] args)
        {
            //Block try/catch for catch any exception
            try
            {
                //The current date and time is stored in the variable "currentDateTime"
                DateTime currentDateTime = DateTime.Now;
                //Print the value of "currentDateTime" on the console
                Console.WriteLine("Current date and time: " + currentDateTime.ToString());
                //Ask the user a number
                Console.WriteLine("Typed a number");
                //Convert the data to integer
                int hours = Convert.ToInt32(Console.ReadLine());
                //Print on the console the value of variable "currentDateTime" plus the hours entered by the user
                Console.WriteLine("Current date and time plus " + hours + " hour(s) is equal to " + currentDateTime.AddHours(hours).ToString());
            }
            //Catch any exception
            catch (Exception e)
            {
                //Print the error on the console
                Console.WriteLine("Error!!!! -> " + e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
