using System;
using System.Collections.Generic;

//Delegat för att förkorta mängden metoder för att hantera iteration och fibonacci
delegate int NumberMethod(int n);

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /*Teori och fakta
         * 1. I stacken läggs nya funktioner på minnet när de startas och tas bort när de är klara. Variablerna städas undan med metodens
         * slut. Heapen ligger kvar tills referensen till minnet tagits bort.
         * 2. Value typer är direkta datatyper. Du anger dom ett värde och sedan pekar dom till detta värde. När de kopieras så kopieras
         * värdet.
         * Reference typer anger i stället en adress till en data, enskild eller grupp. Om du kopierar denna kopieras adressen, och alla
         * kopior pekar till samma instans med data.
         * 3. Den första är value typen int, så när du anger att y = x så kopierar du värdet från x, medans x förblir självständig.
         * Den andra angerer reference typen MyInt, en klass, och då blir y=x en kopia av adressen och båda referar till samma instans av
         * värdet. MyInt som y refererade till först har förlorat sin referens och kommer tas bort från minnet med garbage collection.
        */
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
                    + "\n5. Recursive Even"
                    + "\n6. Recursive Fibonacci"
                    + "\n7. Iterative Even"
                    + "\n8. Iterative Fibonacci"
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
                    case '5':
                        CheckEven(new NumberMethod(RecursiveEven));
                        break;
                    case '6':
                        CheckFibonacci(new NumberMethod(RecursiveFib));
                        break;
                    case '7':
                        CheckEven(new NumberMethod(IterativeEven));
                        break;
                    case '8':
                        CheckFibonacci(new NumberMethod(IterativeFib));
                        break;
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

            //antar att eftersom pdf-en inte säger något om kommentaren ovan så ska jag implementera metoden i pdf i stället för det

            Console.WriteLine("Input a word, get it back reversed. 0 to exit.");

            bool running = true;

            while(running)
            {
                string input = Console.ReadLine();
                Stack<char> reverse = new Stack<char>();

                switch (input[0])
                {
                    case '0':
                        running = false;
                        break;
                    default:
                        break;
                }

                if(running)
                {
                    foreach (char ch in input)
                    {
                        reverse.Push(ch);
                    }

                    while (reverse.Count > 0)
                    {
                        Console.Write(reverse.Pop());
                    }

                    Console.Write("\n");
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            //1.En stack. Senast använda parentesstart är i stacken och tas bort när rätt slut anges.
            //Vi returnerar fel om slutet inte matchar eller om stacken inte är tom när det är klart.
            bool running = true;

            Console.WriteLine("Input a series of parenthesis to check if valid. 0 to escape.");
            while(running)
            {
                string input = Console.ReadLine();

                if (input[0]=='0')
                {
                    running = false;
                }
                else
                {
                    bool valid = true;
                    Stack<char> parenthesis = new Stack<char>();
                    foreach (char ch in input)
                    {
                        switch (ch)
                        {
                            case '(':
                            case '{':
                            case '[':
                                parenthesis.Push(ch);
                                break;
                            case ')':
                                if (parenthesis.Pop() != '(')
                                    valid = false;
                                break;
                            case '}':
                                if (parenthesis.Pop() != '{')
                                    valid = false;
                                break;
                            case ']':
                                if (parenthesis.Pop() != '[')
                                    valid = false;
                                break;
                            default:
                                break;
                        }
                    }

                    if (parenthesis.Count > 0)
                        valid = false;

                    Console.WriteLine(valid);
                }
            }

        }

        static void CheckEven(NumberMethod method)
        {
            NumberMethod even = method;
            bool running = true;

            Console.WriteLine("Input number n that is 0 or more. You will get the nth even number starting from 0. Type e to escape.");

            
            while(running)
            {
                string input = Console.ReadLine();

                if (input[0] == 'e')
                    running = false;
                else
                {
                    Console.WriteLine(even(int.Parse(input)));
                }
            }

        }

        static void CheckFibonacci(NumberMethod method)
        {
            NumberMethod fib = method;
            bool running = true;

            Console.WriteLine("Input number n that is 0 or more. You will get the nth number of the fibonacci sequence. Input e to escape.");

            while (running)
            {
                string input = Console.ReadLine();

                if (input[0] == 'e')
                    running = false;
                else
                {
                    Console.WriteLine(fib(int.Parse(input)));
                }
            }
        }
        //När det kommer till huruvida rekursion eller iteration använder mest minne så är det självklart rekursion.
        //Rekursion lägger på nytt minne i stacken för varje rekursion av metoden och börjar inte ta bort dessa förrän den nått botten.
        //Iteration å andra sidan hanterar å ena sidan samma variabler genom samma iteration, och interna variabler städas bort i slutet
        //av varje iteration.
        //Fördelen med rekursion är att det är snabbare, men inte så pass mycket att det särskilt ofta skulle vara bättre än iteration.
        static int RecursiveEven(int n)
        {
            if (n==0)
            {
                return 2;
            }

            return RecursiveEven(n - 1) + 2;
        }

        static int RecursiveFib(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }

        static int IterativeEven(int n)
        {
            if (n == 0) return 2;

            int result = 2;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }

            return result;
        }

        static int IterativeFib(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;

            int result = 1;
            int prevResult = 0;
            for (int i = 2;i<=n;i++)
            {
                int temp = result;
                result += prevResult;
                prevResult = temp;
            }

            return result;
        }
    }
}

