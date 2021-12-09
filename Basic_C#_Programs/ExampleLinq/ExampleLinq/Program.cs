using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            string[] students = new string[] { "Lacey", "Jhon", "Javier", "Mia"};

            //Define the expression
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 4
                select student;

            //Execute the query
            foreach (string s in studentQuery)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
