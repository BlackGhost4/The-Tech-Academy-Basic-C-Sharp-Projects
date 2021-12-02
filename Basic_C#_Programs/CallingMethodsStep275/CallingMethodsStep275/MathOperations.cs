using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsStep275
{
    //Class "MathOperations" is created
    class MathOperations
    {
        //For the purposes of the exercise, in the class constructor,
        //an integer variable is initialized that will help us in the mathematical operations
        public MathOperations()
        {
            numberB = 4;
        }
        //The variable "numberB" that will help us in the mathematical operations
        public int numberB { get; set; }

        //Method to add the integer parameter with the variable auxNumber
        public int Addition(int auxNumber)
        {
            //return the result of the mathematical operation
            return (numberB + auxNumber);
        }

        //Method to multiplicate the integer parameter with the variable auxNumber
        public int Multiplication(int auxNumber)
        {
            //return the result of the mathematical operation
            return (numberB * auxNumber);
        }

        //Method to subtract the integer parameter with the variable auxNumber
        public int Subtraction(int auxNumber)
        {
            //return the result of the mathematical operation
            return (numberB - auxNumber);
        }
    }
}
