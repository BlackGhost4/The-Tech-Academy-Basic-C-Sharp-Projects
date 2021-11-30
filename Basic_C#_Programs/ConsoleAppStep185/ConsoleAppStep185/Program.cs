using System;

namespace ConsoleAppStep185
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program asks the user for a number
            Console.WriteLine("Enter a number");
            string numberString = Console.ReadLine();
            //The number cast to type "long", to have a value of more than 10,000,000
            long number = Convert.ToInt64(numberString);
            //The number is multiplied by 50, and the print the result in the console
            Console.WriteLine(number + " multiplied by 50 = " + (number * 50));
            //The number is added 25, and the print the result in the console
            Console.WriteLine(number + " plus 25 = " + (number + 25));
            //The number is divided by 50, and the print the result (cast to Double) in the console
            Console.WriteLine(number + " divided by 50 = " + Convert.ToDouble(number / 12.5));
            //The number is greater than 50? The result (boolean) cast to string and the print in the console
            Console.WriteLine(number + " > 50? " + (number > 50).ToString());
            //Print in the console the remainder of the number divided by 7
            Console.WriteLine("The remainder of " + number + " divided by 7 = " + (number % 7).ToString());
            Console.ReadLine();
        }
    }
}
