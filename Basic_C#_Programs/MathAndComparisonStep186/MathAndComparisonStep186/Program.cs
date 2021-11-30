using System;

namespace MathAndComparisonStep186
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the header
            Console.WriteLine("Anonymous Income Comparison Program");
            //First, the program requests the data of person 1
            Console.WriteLine("**** Person 1 ****");
            //Hourly Rate of person 1
            Console.WriteLine("Hourly Rate");
            //Cast the enter value to Decimal type
            decimal person1_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            //Hours worked per week of person 1
            Console.WriteLine("Hours worked per week");
            //Cast the enter value to Int type
            int person1_HoursWorkedPerWeek = Convert.ToInt32(Console.ReadLine());
            //Calculate the Annual Salary for Person 1
            decimal person1_AnnualSalary = (person1_HourlyRate * person1_HoursWorkedPerWeek) * 52;

            //Later, the program requests the data of person 2
            Console.WriteLine("**** Person 2 ****");
            //Hourly Rate of person 2
            Console.WriteLine("Hourly Rate");
            //Cast the enter value to Decimal type
            decimal person2_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            //Hours worked per week of person 2
            Console.WriteLine("Hours worked per week");
            //Cast the enter value to Int type
            int person2_HoursWorkedPerWeek = Convert.ToInt32(Console.ReadLine());
            //Calculate the Annual Salary for Person 2
            decimal person2_AnnualSalary = (person2_HourlyRate * person2_HoursWorkedPerWeek) * 52;

            //Print in the console the Annual Salary for the Person 1 and Person 2
            Console.WriteLine("Annual salary of Person 1: " + person1_AnnualSalary.ToString());
            Console.WriteLine("Annual salary of Person 2: " + person2_AnnualSalary.ToString());

            //Calculate if the Person 1 make more money than and Person 2, and print the result in te console
            Console.WriteLine("Does Person 1 make more money than Person 2? " + (person1_AnnualSalary > person2_AnnualSalary).ToString());
            //Wait until the user presses the enter key
            Console.ReadLine();
        }
    }
}
