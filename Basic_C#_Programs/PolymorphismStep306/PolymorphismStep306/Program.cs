using System;

namespace PolymorphismStep306
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Employee object
            IQuittable employee = new Employee();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
