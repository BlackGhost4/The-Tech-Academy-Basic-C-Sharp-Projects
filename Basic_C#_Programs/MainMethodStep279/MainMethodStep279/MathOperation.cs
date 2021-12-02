using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodStep279
{
    //Class x is created
    class MathOperation
    {
        public MathOperation()
        {
            //The variable is initialized and it will help us in the mathematical operation of addition
            auxNumber = 8;
        }
        //I use the variable that it will help us in the mathematical operation of addition
        public int auxNumber { get; set; }

        //The Addition method is created with an integer parameter
        public int Addition(int wholeNumber)
        {
            return wholeNumber + auxNumber;
        }

        //The Addition method is created with a decimal parameter
        public int Addition(decimal decimalNumber)
        {
            return Convert.ToInt32(decimalNumber) + auxNumber;
        }

        //The Addition method is created with a string parameter
        public int Addition(string stringNumber)
        {
            //If there is an error, it is transmitted to Main(), where that error is caught and the message is displayed on the console
            return Convert.ToInt32(stringNumber) + auxNumber;
        }
    }
}
