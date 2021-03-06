using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionStep285
{
    //******************************************************************************
    //The class "ExampleClass" is created
    //******************************************************************************
    class ExampleClass
    {
        /************************************************************************
         * As the class is static, the method must be static as too
         * Acept a whole number and is stored in the variable numberA
         * **********************************************************************/
        public void Divide(int numberA, out int numberB)
        {
            //If the number can be divided by 2, the mathematical operation is done
            if ((numberA % 2) == 0)
            {
                numberB = numberA / 2;
            }
            //otherwise, the variable numberB is assigned a value of -1
            else
            {
                numberB = -1;
            }
        }

        /************************************************************************
         * As the class is static, the method must be static as well
         * **********************************************************************/
        public void Divide(string numberA, out int numberB)
        {
            //The variable numberA (string) cast to Integer and the Divide method is called with that value
            Divide(Convert.ToInt32(numberA), out numberB);
        }
    }
}
