using System;

namespace MethodsAndObjectsStep292
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
