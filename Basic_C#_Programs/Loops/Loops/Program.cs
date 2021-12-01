using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGuessed = false;

            do
            {
                Console.WriteLine("Guess a number?");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4. That is correct!!!!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Try again.");
                        break;
                }
            } while (!isGuessed);
            Console.ReadLine();
        }
    }
}
