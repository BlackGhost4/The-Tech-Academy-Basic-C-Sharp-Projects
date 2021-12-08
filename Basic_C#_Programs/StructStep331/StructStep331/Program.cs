using System;

namespace StructStep331
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the next line the data Type Number is created and send the decimal value "234.23"
            Number number = new Number(Convert.ToDecimal(234.23));
            //Print the value of the "Amount" on the console
            Console.WriteLine("The amount is " + number.Amount);
            Console.ReadLine();
        }

        //The struct "Number" is created
        public struct Number
        {
            //The constructor receives a decimal value and stores it in the variable Amount
            public Number(decimal value)
            {
                Amount = value;
            }

            //Property "Amount" of the Struct "Number"
            public decimal Amount { get; init;  }
        }
    }
}
