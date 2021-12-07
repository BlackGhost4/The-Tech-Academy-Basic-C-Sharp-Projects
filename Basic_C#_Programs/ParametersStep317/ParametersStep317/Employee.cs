using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersStep317
{
    //The class "Employee" is created with a generic type parameter
    public class Employee<T>
    {
        //Add a property to the Employee class called “things”
        public List<T> things { get; set; }
    }
}
