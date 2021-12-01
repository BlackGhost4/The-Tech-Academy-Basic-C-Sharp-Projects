using System;
using System.Text;

namespace StringAssignmentStep233
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize tree string
            string string1 = "Hello World !!!! ";
            string string2 = " My name is";
            string string3 = " Engels";

            //Concat the last string in the "concatString" variable
            string concatString = string.Concat(string1, string2, string3);
            Console.WriteLine(concatString);
            //To uppercase the "concatString" variable
            Console.WriteLine(concatString.ToUpper());

            //Create a string builder with the name "sb"
            StringBuilder sb = new StringBuilder();
            //Append four lines in the variable
            sb.Append("Hello, my name is Engels");
            sb.Append("\nI\'m from Mexico");
            sb.Append("\n and I Like coding");
            sb.Append("\n\"Coding is my cardio\"");
            //Print in the console the "sb" variable
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
