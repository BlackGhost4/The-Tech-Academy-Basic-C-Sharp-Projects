using System;

namespace ConsoleAppSubmissionStep229
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable "number" is initialized to 4
            int number = 4;
            //the value is requested
            Console.WriteLine("\"While Statement\"");
            //For the finish the loop, the value of the number must be greater than 4
            while (number <= 4)
            {
                Console.WriteLine("For finish this loop enter a number greater than 4");
                number = Convert.ToInt32(Console.ReadLine());
            }
            //the loop is finished
            Console.WriteLine("Loop of the \"While Statement\" are finished");
            Console.WriteLine("\n\"Do While Statement\"");
            //enters the loop without performing a variable condition
            do
            {
                Console.WriteLine("For finish this loop enter a number less than 4");
                number = Convert.ToInt32(Console.ReadLine());
            }
            //the loop finish, when the number is less than 4
            while (number >= 4);
            Console.WriteLine("Loop of the \"Do While Statement\" are finished");
            Console.ReadLine();
        }
    }
}
