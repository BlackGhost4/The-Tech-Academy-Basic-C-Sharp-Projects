using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your First Name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\Engels Molina\Documents\Repositorios\The-Tech-Academy-Basic-C-Sharp-Projects\NetCore\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n\nTotal of " + lines.Length + " student scores. \tAverage score " + avgScore);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
