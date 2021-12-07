using System;
using System.Collections.Generic;

namespace ParametersStep317
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string” as its generic parameter
            Employee<string> stringNumbers = new Employee<string>();
            //Assign a list of strings as the property value of Things.
            stringNumbers.things = new List<string>();
            stringNumbers.things.Add("Uno");
            stringNumbers.things.Add("Dos");
            stringNumbers.things.Add("Tres");
            stringNumbers.things.Add("Cuatro");
            stringNumbers.things.Add("Cinco");
            stringNumbers.things.Add("Seis");
            stringNumbers.things.Add("Siete");
            stringNumbers.things.Add("Ocho");
            stringNumbers.things.Add("Nueve");
            stringNumbers.things.Add("Diez");

            //Instantiate an Employee object with type “int” as its generic parameter
            Employee<int> intNumbers = new Employee<int>();
            //Assign a list of integers as the property value of Things
            intNumbers.things = new List<int>();
            intNumbers.things.Add(1);
            intNumbers.things.Add(2);
            intNumbers.things.Add(3);
            intNumbers.things.Add(4);
            intNumbers.things.Add(5);
            intNumbers.things.Add(6);
            intNumbers.things.Add(7);
            intNumbers.things.Add(8);
            intNumbers.things.Add(9);
            intNumbers.things.Add(10);

            //Print all items to the console
            foreach (string stN in stringNumbers.things)
            {
                Console.WriteLine(stN);
            }

            foreach (int itN in intNumbers.things)
            {
                Console.WriteLine(itN);
            }

            Console.ReadLine();
        }
    }
}
