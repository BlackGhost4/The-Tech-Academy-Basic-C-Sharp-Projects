using System;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the header in the console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Package weight is requested
            Console.WriteLine("what is the weight of the package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Error: Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("what is the width of the package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("what is the height of the package?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("what is the length of the package?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if ((packageWidth + packageHeight + packageLength) > 50)
                {
                    Console.WriteLine("Error: Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal totalForShipping = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + string.Format("{0:0.00}", totalForShipping) + " USD");
                }
            }
            Console.ReadLine();
        }
    }
}
