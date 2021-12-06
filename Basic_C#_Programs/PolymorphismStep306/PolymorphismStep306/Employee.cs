using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStep306
{
    //The class "Employee" is created, and inherit from the "Person" class
    public class Employee : Person, IQuittable
    {
        //Implementation of IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Method Quit()");
        }
    }
}
