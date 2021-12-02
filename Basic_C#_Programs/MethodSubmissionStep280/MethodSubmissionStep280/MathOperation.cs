using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionStep280
{
    //The class "MathOperation" is created
    class MathOperation
    {
        //The method "Multiplication" is created
        //This method take one or two parameters, the second parameter is optional and has a default value of 4
        public int Multiplication(int numberA, int numberB = 4)
        {
            //Return the result of numberA multiplied by numberB
            return numberA * numberB;
        }
    }
}
