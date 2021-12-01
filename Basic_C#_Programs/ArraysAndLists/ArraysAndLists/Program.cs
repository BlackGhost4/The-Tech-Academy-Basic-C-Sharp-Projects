using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();

            intList.Add("Hello");
            intList.Add("Engels");
            intList.Remove("Engels");
            Console.WriteLine(intList[0]);

            //int[] numberArray = new int[5];
            //numberArray[0] = 5;
            //numberArray[1] = 2;
            //numberArray[2] = 10;
            //numberArray[3] = 200;
            //numberArray[4] = 5000;

            //int[] numberArray2 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //int[] numberArray3 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numberArray3[5] = 650;

            //Console.WriteLine(numberArray3[5]);
            Console.ReadLine();
        }
    }
}
