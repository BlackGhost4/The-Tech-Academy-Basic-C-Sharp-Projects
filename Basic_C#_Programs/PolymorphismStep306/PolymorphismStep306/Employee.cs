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
        //The virtual method of the "Person" class is implemented in the "Employee" class
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Quit()");
        }
    }
}
