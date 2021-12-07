using System;

namespace ParsingEnumsStep324
{
    class Program
    {
        /*****************************************************************************************
         * This program does the following:
         *
         *  1. Prompts the user for the current day of the week.
         *  2. Verify that the entered value is a valid day of the week, either by number of the 
         *     week (from 1 to 7) or by name of the day (Monday, Tuesday, etc).
         *     a. If it is valid, it shows the message "The day entered is correct!!!!".
         *     b. If it is not valid, it shows the message "Please enter a valid number for the week."
         *        or "Please, enter a valid data for the day of the week."
         *  5. In addition to the above, if the entered value is the current day of the week, 
         *     it shows the message "Great, this is the current day of the week :) !!!!!!!!!!!!",
         *     otherwise, it throws its own exception called "NotCurrentDayException" with the 
         *     message "It is not the current day of the week"
         *  6. The program ends, when the user types "exit", this was done to make several entries 
         *     to the system and validate its operation.
        ******************************************************************************************/
        static void Main(string[] args)
        {
            DaysOfWeek daysOfWeek;
            string value = "";
            do
            {
                try
                {
                    //Prompt the user to enter the current day of the week.
                    Console.WriteLine("\nPlease enter a current day of the week");
                    //Store the data in the variable "value"
                    value = Console.ReadLine();
                    //Try parse "value" to enum DaysOfWeek
                    if (Enum.TryParse(value, true, out daysOfWeek))
                    {
                        //If it is valid, check if the value is a whole number from 0 to 6 (numbers of the days of the week)
                        int day;
                        if (Int32.TryParse(value, out day))
                        {
                            if (day >= 0 && day <= 6)
                            {
                                //If it a valid number of the week, show the next message on the console
                                Console.WriteLine("The day entered is correct!!!!");
                                if ((int)new DateTime().DayOfWeek == day)
                                    //If it is the current day of the week, show the next message on the console
                                    Console.WriteLine("Great, this is the current day of the week :) !!!!!!!!!!!!");
                                else
                                    //If not, throw its own exception
                                    throw new NotCurrentDayException("It is not the current day of the week");
                            }
                            else
                            {
                                //If not a valid number of the week, throws an exception
                                throw new Exception("Please enter a valid number for the week.");
                            }
                        }
                        else
                        {
                            //If it is not a number, it is assumed that it is a valid name for the day
                            Console.WriteLine("The day entered is correct!!!!");
                            if ((int)new DateTime().DayOfWeek == (int)daysOfWeek)
                                //If it is the current day of the week, show the next message on the console
                                Console.WriteLine("Great, this is the current day of the week :) !!!!!!!!!!!!");
                            else
                                //If not, throw its own exception
                                throw new NotCurrentDayException("It is not the current day of the week");
                        }
                    }
                    else
                    {
                        //If the value entered by the user could not be passed to the DaysOfWeek, throw an exception
                        throw new Exception("Please, enter a valid data for the day of the week.");
                    }
                }
                //Catch any exceptions thrown in the system
                catch (NotCurrentDayException e)
                {
                    Console.WriteLine("Sorry :( "+ e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!!! -> " + e.Message);
                }
            } while (!value.ToUpper().Contains("EXIT")); //The program ends when the user typed "exit"
        }

        //Days of the week
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
