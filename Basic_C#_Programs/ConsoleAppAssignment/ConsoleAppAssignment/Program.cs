using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            //The variable numberIterations will be used to end the cycle, if the user has not select the option 3
            //and the program has been repeated 8 times when the condition is "<=",
            //or 7 times when the condition is "<"
            int numberIterations = 1;

            //************************************************************************
            //**                 PART TWO                                           **
            //while (true) ******** This instruction creates an infinite loop ********
            //************************************************************************

            //****************************************************************************************************************************
            //**                 PART THREE                                                                                             **
            //The next instruction end the program when the user typed "exit" or the program has been repeated 8 times (<=) or 7 times (<)
            //NOTE: Just only the operadot < is changed by <= or vice versa
            //****************************************************************************************************************************
            while (option != 5 && numberIterations <= 8)
            {
                //Print a principal menu
                Console.WriteLine("\n\nHello!!!! Select an option of the next menu");
                Console.WriteLine("\n1. Send a greeting.");
                Console.WriteLine("2. Find one element in a list.");
                Console.WriteLine("3. Find two elements in a list.");
                Console.WriteLine("4. Find repeating strings in a list.");
                Console.WriteLine("5. EXIT.");
                Console.Write("\nPlease, select an option (1-3): ");
                //The entered value is stored in the "option" variable
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            //call the procedure SendGreeting
                            SendGreeting();
                            break;
                        case 2:
                            //call the procedure FindInTheList
                            FindInTheList();
                            break;
                        case 3:
                            //call the procedure FindTwoInTheList
                            FindTwoInTheList();
                            break;
                        case 4:
                            //call the procedure FindRepeatItemsInTheList
                            FindRepeatItemsInTheList();
                            break;
                        case 5:
                            break;
                        default:
                            //Print an error message on the console
                            Console.WriteLine("**** THE OPTION IS NOT VALID!!!! ****");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("**** THE OPTION IS NOT VALID!!!! ****");
                }
                numberIterations++;
            }
        }

        public static void SendGreeting()
        {
            //Array with 8 names
            string[] names = { "Engels", "Andrew", "Jhon", "Sara", "Luis", "Jeremias", "Jonathan", "Steve" };
            string greeting = "";

            //The next instruction return the menu when the user typed "menu"
            while (!greeting.ToUpper().Equals("MENU"))
            {
                Console.WriteLine("\n\nHello!!!! Please type a greeting....");
                Console.WriteLine("NOTE: to return to the menu, type \"menu\"");
                //The entered value is stored in the "greeting" variable
                greeting = Console.ReadLine();
                for (int index = 0; index < names.Length; index++)
                {
                    //In this line, the greeting is concatenated to the names
                    names[index] = string.Concat(names[index], " ", greeting);
                }
                for (int index = 0; index < names.Length; index++)
                {
                    //Print in the console the name with the greeting
                    Console.WriteLine(names[index]);
                }
            }
        }

        //This procedure find a color in a list
        public static void FindInTheList()
        {
            //List with 8 color, none is repeated
            List<string> colors = new List<string>() { "RED", "WHITE", "YELLOW", "BLACK", "BLUE", "ORANGE", "PURPLE", "BROWN" };
            //flag to finish the program and return to menu
            bool finish = false;
            //variable that will store the color to look for
            string colorAsked = "";
            while (!finish)
            {
                Console.WriteLine("\n\nHello!!!! Please type a color to search....");
                Console.WriteLine("NOTE: to return to the menu, you must find the color: it is indistinct to write it in uppercase or lowercase.");
                //Store the value in the variable "colorAsked"
                colorAsked = Console.ReadLine();
                for (int index = 0; index < colors.Count; index++)
                {
                    if (colors[index].ToUpper().Equals(colorAsked.ToUpper()))
                    {
                        //print on the console, the index of the found color list
                        Console.WriteLine("Congratulations :-) you found the color!!!! Is in the index " + index);
                        //the "finish" flag is set to the true value for the finish teh procedure and return to menu 
                        finish = true;
                        break;
                    }
                }
                if (!finish)
                {
                    //if color was not found, print an message on the console
                    Console.WriteLine("Sorry, try again :-( color was not found");
                }
            }
        }

        //This procedure find a color that repeats twice in a list
        public static void FindTwoInTheList()
        {
            //List a colors; the color blue it is in the indexes 3 and 7
            List<string> colors = new List<string>() { "RED", "WHITE", "YELLOW", "BLACK", "BLUE", "ORANGE", "PURPLE", "BLUE" };
            //In the varibale "indices", the indices that were found will be stored
            List<int> indices = new List<int>();
            //Flag that finish the procedure and return to menu
            bool finish = false;
            //this variable will store the value typed by the user
            string colorAsked = "";
            while (!finish)
            {
                Console.WriteLine("\n\nHello!!!! Please type the color that repeats twice in the color list....");
                Console.WriteLine("NOTE: to return to the menu, you must find the color: it is indistinct to write it in uppercase or lowercase.");
                //Store the value in the variable "colorAsked"
                colorAsked = Console.ReadLine();
                for (int index = 0; index < colors.Count; index++)
                {
                    //if color is in the list
                    if (colors[index].ToUpper().Equals(colorAsked.ToUpper()))
                    {
                        //the index of the color entered is added to the list
                        indices.Add(index);
                    }
                }
                //If color was found 2 times
                if (indices.Count == 2)
                {
                    //Print the indices on the console
                    Console.Write("Congratulations :-) you found the color!!!! Is in the indexes ");
                    foreach(int i in indices)
                    {
                        Console.Write(i + "  ");
                    }
                    finish = true;
                }
                //if the color was found only once
                else if (indices.Count == 1)
                {
                    //print a message in the console
                    //************************************************************************************************************************************
                    //To solve part 5, add the next statement:    but this is in the index " + indices[0]
                    Console.WriteLine("Sorry, try again :-( color does not repeat twice and was found only once, but this is in the index " + indices[0]);
                    //clear the list
                    indices.Clear();
                }
                //If color was not found
                else
                {
                    //print a message in the console that color was not found
                    Console.WriteLine("Sorry, try again :-( color was not found");
                    //clear the list
                    indices.Clear();
                }
            }
        }

        //This procedure find the repetitions of an item in the list.
        //Return to menu automatically.
        public static void FindRepeatItemsInTheList()
        {
            //A list with indistinct values is created
            List<string> words = new List<string>() { "one", "academy", "camp", "mouse", "one", "mouse", "one", "black", "mouse", "yellow", "mouse" };
            //Another list is created, in that list the items of the first list will be copied
            List<string> auxWords = new List<string>();
            //the items from the "words" list are copied to "auxWords" list
            words.ForEach(w => auxWords.Add(w));
            //A list is created where the indices of the repeated words will be stored
            List<int> itemsInList = new List<int>();
            //The cycle repeats until there are no elements in the words list, since all the words
            //that were already searched are eliminated from the list "words"
            while (words.Count > 0)
            {
                //The variable itemsInList is clear
                itemsInList.Clear();
                //To the variable "word" is set the firs item in the list "word"
                string word = words[0];
                //That word is searched in the list auxWords 
                for (int i = 0; i < auxWords.Count; i++)
                {
                    if (word.ToUpper().Equals(auxWords[i].ToUpper()))
                    {
                        //If exist, then store in the itemsInList
                        itemsInList.Add(i);
                    }
                }
                //If itemsInList is equl than 1, then the word is not repeated
                if (itemsInList.Count <= 1)
                {
                    Console.WriteLine("The word " + word + " is not repeated");
                }
                //if not, it was found two or more times
                else
                {
                    //Print the indices on the console
                    Console.Write("The word " + word + " is repeated in the items:");
                    foreach (int item in itemsInList)
                    {
                        Console.Write("\t" + item);
                    }
                    Console.Write("\n");
                }
                //All the words that have already been searched are removed from the list
                words.RemoveAll(w => w.Equals(word));
            }
        }
    }
}