using System;

namespace AbstractClassStep302
{
    class Program
    {
        static void Main(string[] args)
        {
            //The "employee" object isinstantiated with FirstName = Sample and LastName = Student
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the "SayName" method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
