using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsStep292
{
    //The class "Person" is created
    public class Person
    {
        //Add at the class two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //The method "SayName" is created
        public void SayName()
        {
            //Print the full name on the console
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
