using System;
using System.Collections.Generic;

namespace ConsoleAppArraySubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays are initialized with 8 values each
            string[] colorArray = { "Yellow", "Red", "Black", "Blue", "White", "Orange", "Purple", "Green" };
            int[] numberArray = { 5, 4, 9, 67, 1404, 3923, 2343, 10 };
            List<string> things = new List<string>();
            things.Add("Car");
            things.Add("Computer");
            things.Add("Mouse");
            things.Add("Screen");
            things.Add("Pencil");
            things.Add("Glass");
            things.Add("Chair");
            things.Add("Keyboard");
            //The variable "exitLoop", will store the data entered by the user
            string exitLoop = "";
            int index = 0;

            //Print the instructions in the console
            Console.WriteLine("Welcome to Console App Array Submission");
            Console.WriteLine("\nThere are two arrangements with 8 elements each. The first array is of \"colors\" and the second is of \"numbers\"");
            Console.WriteLine("\nAlso, there is a list of \"things\" with 8 items.");
            do
            {
                //The data is requested, for finish the program the user must type "exit"
                Console.WriteLine("Enter the value of the index to display an element (0-7). NOTE: For the finish the program enter the word \"exit\"");
                exitLoop = Console.ReadLine();
                //In the next line, an attempt is made to pass the entered value to a numeric type
                if (int.TryParse(exitLoop, out index))
                {
                    //In case the data is a number, it is verified that area a number between in 0 and 7
                    if (index >= 0 && index <= 7)
                    {
                        //If it is true, it is printed the value in the position of the arrays
                        Console.WriteLine("The value of the color in the position " + index + ", is: " + colorArray[index]);
                        Console.WriteLine("The value of the number in the position " + index + ", is: " + numberArray[index]);
                        Console.WriteLine("The value in the list of things that is in position " + index + ", is: " + things[index]);
                    }
                    else
                    {
                        //If it is false, it is printed a message
                        Console.WriteLine("The number doesn’t exist");
                    }
                }
                //If the data entered is not a number, the program print in the console the message
                else
                {
                    Console.WriteLine("The number is not valid");
                }
            //The loop ends when the user type a word "exit"
            }while (!exitLoop.ToUpper().Equals("EXIT"));
        }
    }
}
