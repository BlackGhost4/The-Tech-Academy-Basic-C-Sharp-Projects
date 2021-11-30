using System;

namespace BooleanLogicStep199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOOLEAN LOGIC SUBMISSION ASSIGNMENT");
            //The program ask the user's age
            Console.WriteLine("\nWhat is your age?");
            //Store the vaue in a varible "age" of int type
            int age = Convert.ToInt32(Console.ReadLine());
            //The program ask if the user ever had a DUI
            Console.WriteLine("\nHave you ever had a DUI? (true or false)");
            //Store the vaue in a varible "haveEverDui" of bool type
            bool haveEverDui = Convert.ToBoolean(Console.ReadLine());
            //The program ask the number of speeding tickets the user has
            Console.WriteLine("\nHow many speeding tickets do you have?");
            //Store the vaue in a varible "speedingTickets" of int type
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nApplicant qualifies for car insurance?");
            /* Print the result in the console with the following rules
            A. Applicants must be over 15 years old.
            B. Applicants must not have any DUI’s.
            C. Applicants must not have more than 3 speeding tickets. */
            Console.WriteLine(age > 15 && haveEverDui == false && speedingTickets <= 3);
            Console.ReadLine();
        }
    }
}
