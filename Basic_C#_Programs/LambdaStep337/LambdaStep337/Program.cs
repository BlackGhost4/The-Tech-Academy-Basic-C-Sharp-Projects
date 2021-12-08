using System;
using System.Collections.Generic;

namespace LambdaStep337
{
    class Program
    {
        static void Main(string[] args)
        {
            //A list with 10 employees is created
            List<Employee> employees = new List<Employee>() { 
                new Employee { id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { id = 2, FirstName = "Juan", LastName = "Bautista" },
                new Employee { id = 3, FirstName = "Marya", LastName = "Fernandez" },
                new Employee { id = 4, FirstName = "Alma", LastName = "Hernandez" },
                new Employee { id = 5, FirstName = "Joe", LastName = "Peralta" },
                new Employee { id = 6, FirstName = "Pedro", LastName = "Fernandez" },
                new Employee { id = 7, FirstName = "Jose", LastName = "Cardenas" },
                new Employee { id = 8, FirstName = "Lilia", LastName = "Morelos" },
                new Employee { id = 9, FirstName = "Francisco", LastName = "Linares" },
                new Employee { id = 10, FirstName = "Javier", LastName = "Meza" },
            };

            //Using a foreach, a list is created with the employees with the name "Joe", from the list employees
            List<Employee> newEmployees = new List<Employee>();
            foreach (Employee auxEmployee in employees)
            {
                if (auxEmployee.FirstName.Equals("Joe"))
                {
                    newEmployees.Add(auxEmployee);
                }
            }
            //Print the items of the list "newEmployees" on the console
            Console.WriteLine("List newEmployees");
            PrintOnTheConsole(newEmployees);

            //Using a lambda expression, a list is created with the employees with the name "Joe", from the list employees
            List<Employee> newEmployeesLambda = employees.FindAll(x => x.FirstName.Equals("Joe"));
            //Print the items of the list "newEmployeesLambda" on the console
            Console.WriteLine("\nList newEmployeesLambda");
            PrintOnTheConsole(newEmployeesLambda);

            //Using a lambda expression, a list is created with the employees with the id greather than 5, from the list employees
            List<Employee> newEmployeesLambda2 = employees.FindAll(x => x.id > 5);
            //Print the items of the list "newEmployeesLambda2" on the console
            Console.WriteLine("\nList newEmployeesLambda2");
            PrintOnTheConsole(newEmployeesLambda2);

            Console.ReadLine();
        }

        //Method for print on the console the items of a list of employees
        public static void PrintOnTheConsole(List<Employee> listEmployees)
        {
            foreach(Employee auxE in listEmployees)
            {
                Console.WriteLine("id = |" + auxE.id  + "|\tFirstName = |" + auxE.FirstName + "|\t\tLastName = |" + auxE.LastName + "|");
            }
        }
    }
}
