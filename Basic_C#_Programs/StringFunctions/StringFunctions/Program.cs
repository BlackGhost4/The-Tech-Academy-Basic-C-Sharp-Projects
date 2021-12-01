using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engels";
            //string quote = "The man said: \"Hello\", Engels.\nNew Line.\n\t is a tab";
            //string fileName = @"C:\Users\Engels";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");
            //int length = name.Length;

            //Console.WriteLine(quote);
            //Console.WriteLine(fileName);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Engels");

            Console.ReadLine();
        }
    }
}
