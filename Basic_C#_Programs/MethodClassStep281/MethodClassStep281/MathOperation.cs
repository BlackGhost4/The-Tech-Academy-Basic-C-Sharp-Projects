using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassStep281
{
    //The class "MathOperation" is created
    class MathOperation
    {
        //The method "Multiplication" is created
        //This method has a two parameters, the second parameter will store the result of the mathematical operation numberA * 4
        public void Multiplication(int numberA, out int numberB)
        {
            numberB = numberA * 4;
        }
    }
}
