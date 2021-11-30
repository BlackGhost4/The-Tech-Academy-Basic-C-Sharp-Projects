using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                if (number <= 10)
                {
                    Console.WriteLine("The number is less or equal than 10");
                }
                else if (number <= 20)
                {
                    Console.WriteLine("The number is less or equal than 20");
                }
                else if (number > 20 && number <= 50)
                {
                    Console.WriteLine("The number is more than 20 and less or equal than 50");
                }
                else
                {
                    Console.WriteLine("The number is more than 50");
                }
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.WriteLine(number < 0 ? "The number is negative" : number == 0 ? "The number is zero" : "The number is positive");
            Console.ReadLine();
        }
    }
}
