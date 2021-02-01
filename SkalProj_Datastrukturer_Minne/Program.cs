using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            Console.WriteLine("String preceded by + sign adds to list.\n" +
                "String preceded by - removes that given string from it.\n" +
                "In response you will know the count and capacity of the list.\n" +
                "0 to exit this function.");
            
            bool running = true;
            List<string> theList = new List<string>();

            while (running)
            {
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Count: {theList.Count}\nCapacity: {theList.Capacity}");
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine($"Count: {theList.Count}\nCapacity: {theList.Capacity}");
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Only strings preceded by + or - operate the list");
                        break;
                }

                /*
                 * 2. Listans kapacitet ökar när listans storlek är större än nuvarande array.
                 * 3. Arrayen har storlek 0 innan element läggs till. Med det första elementet får det storlek 4.
                 * Efter det dubblerar arrayen i storlek varje gång kapaciteten överträffas.
                 * 4. Eftersom enda sättet att öka storleken på en array är att kopiera innehållet till en ny med större kapacitet.
                 * Det blir onödigt många minneshanteringar.
                 * 5. Kapaciteten minskar aldrig.
                 * 6. Array är fördelaktig när du vet att du kommer ha en fixerad storlek, eller om du vill ha bättre kontroll över när den ökar
                 * i storlek. Sen så kan den också vara multi-dimensionell till skillnad från listor.
                 */
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            bool running = true;
            Queue<string> theQueue = new Queue<string>();

            Console.WriteLine("String preceded by + sign adds to queue.\n" +
                "- sign deques first item in queue. Even if you add more to the string it will be ignored.\n" +
                "As you dequeue the exiting element will be returned.\n" +
                "0 to exit this function.");

            while (running)
            {
                string input = Console.ReadLine();
                char nav = input[0];

                switch(nav)
                {
                    case '+':
                        theQueue.Enqueue(input.Substring(1));
                        break;
                    case '-':
                        Console.WriteLine(theQueue.Dequeue());
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("+ or - to manipulate queue");
                        break;
                }
            }

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

