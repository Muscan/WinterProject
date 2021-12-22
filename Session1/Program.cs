using System;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Winter");

            Console.WriteLine("HelloWorld");
            //Declare a variable and increment it with one
            int firstNumber = 0;
            firstNumber = firstNumber + 1;

            //Print your names
            Console.WriteLine("Your Name");
            Console.WriteLine("Your First");
            Console.WriteLine("Your Middle");
            Console.Write("Your Last Name\n");
            //Create a console application that prints the current date and time.
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);

            //Read a text from the console and print it
            //Create a console application that reads a text from the user, in the console, and stores the value in a variable.
            //Print the variable to the console, together with the text "The value of the variable is"
            Console.WriteLine("Insert a text and press enter: ");
            string readLine = Console.ReadLine();

            /*Read a text from the console, check value and print a message
              Create a console application that reads a text from the user, 
              in the console, and stores the value in a variable.
              If the text has the value "exit", print the message 
              "User commands exit"; if the value is different then print "Still in program"*/

            Console.WriteLine("Insert a text and press enter: ");
            string inputFromUser = Console.ReadLine();
            if (inputFromUser == "exit")
            {
                Console.WriteLine("User comands exit");

                return;//Exists from the function
            }
            else
            {
                Console.WriteLine("Still in program");
            }

            PrintNumbersWhichDivideBy5(10);

            //InfiniteLoop(1);

            EraseSpecificPosition("ABC", 1);

        }

        public static void PrintNumbersWhichDivideBy5(int nr)
        {
            for (int i = 0; i <= 200; i++)
            {

                if (i % 5 == 0)
                {
                    Console.Write(i + " ");

                }

            }
        }

        public static void InfiniteLoop(int nr)
        {
            for (int i = 0; i < nr; i++)
            {
                while (1 == 1)
                {
                    Console.Write(i + " Infinit ");
                }
            }
        }
      
        public static void EraseSpecificPosition(string text, int position)
        {

            if (position >= 0 && position <= text.Length)
            {
                string newText = "";
                newText = text.Substring(0, position) + text.Substring(position + 1);
                Console.WriteLine($"New text is: {newText}");
            }
            else
            {
                Console.WriteLine("Position out of range");
            }


        }
    }
}
