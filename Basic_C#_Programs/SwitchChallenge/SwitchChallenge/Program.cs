using System;

namespace SwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a rol (Administrator, Operator, User");
            string roleUser = Console.ReadLine();
            switch (roleUser)
            {
                case "Administrator":
                    Console.WriteLine("You have all permissions in the system");
                    break;
                case "Operator":
                    Console.WriteLine("You have medium level permissions in the system");
                    break;
                case "User":
                    Console.WriteLine("You have low level permissions in the system");
                    break;
                default:
                    Console.WriteLine("You don\'t have permissions in the system");
                    break;
            }
            Console.ReadLine();
        }
    }
}
