using System;
using System.IO;

namespace InputAssignmentStep365
{
    class Program
    {
        static void Main(string[] args)
        {
            //A variable is created with the file path
            string fileName = @"c:\logs\log.txt";
            //Ask the user for a number
            Console.WriteLine("Please typed a number");
            //These data is stored in the variable number
            string number = Console.ReadLine();
            //The System.IO namespace is used to use the class that have a method that will store the
            //value in the file. Note: The path must exist for the method to work, otherwise it will throw an exception
            using (StreamWriter file = new StreamWriter(fileName, true))
            {
                //Store the new line with the data
                file.WriteLine(number);
            }

            //Subsequently, the full content of the file is shown to the user
            Console.WriteLine("The file " + fileName + " contains:");
            string dataOfFile = File.ReadAllText(fileName);
            Console.WriteLine(dataOfFile);
            Console.ReadLine();
        }
    }
}
