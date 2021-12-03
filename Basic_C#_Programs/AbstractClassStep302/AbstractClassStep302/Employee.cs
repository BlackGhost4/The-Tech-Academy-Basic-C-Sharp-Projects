using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassStep302
{
    //The class "Employee" is created, and inherit from the "Person" class
    class Employee : Person
    {
        //The virtual method of the "Person" class is implemented in the "Employee" class
        public override void SayName()
        {
            base.SayName();
        }
    }
}
