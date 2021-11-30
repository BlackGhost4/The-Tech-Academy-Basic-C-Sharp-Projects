using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());

            //int product = 10 * 5;
            //Console.WriteLine(product);

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
