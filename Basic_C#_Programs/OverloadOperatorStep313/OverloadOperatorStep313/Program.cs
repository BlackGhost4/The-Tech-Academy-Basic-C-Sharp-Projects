using System;

namespace OverloadOperatorStep313
{
    class Program
    {
        static void Main(string[] args)
        {
            //The object "employee1" is crated
            Employee employee1 = new Employee();
            employee1.id = 1;
            employee1.FirstName = "Engels";

            //The object "employee2" is created
            Employee employee2 = new Employee();
            employee2.id = 1;
            employee2.FirstName = "Andrew";

            //Print the result of the ID comparison on the console
            if (employee1 == employee2)
            {
                Console.WriteLine("The Id of Employee " + employee1.FirstName + " is equal to that employee " + employee2.FirstName);
            }
            else
            {
                Console.WriteLine("The Id of Employee " + employee1.FirstName + " is not equal to that employee " + employee2.FirstName);
            }

            //Change the "id" in employee2
            employee2.id = 2;
            //Print the result of the ID comparison on the console
            if (employee1 == employee2)
            {
                Console.WriteLine("The Id of Employee " + employee1.FirstName + " is equal to that employee " + employee2.FirstName);
            }
            else
            {
                Console.WriteLine("The Id of Employee " + employee1.FirstName + " is not equal to that employee " + employee2.FirstName);
            }

            Console.ReadLine();
        }
    }
}
