using System;

// Namespace.
namespace NumberGuesser
{
    // Main class.
    class Program
    {
        // Entry point method.
        static void Main(string[] args)
        {

            // Run GetAppInfo to get info.
            GetAppInfo();

            // Ask for user's name and greet.
            GreetUser();

            while (true)
            {

                // Initialize correct number.
                //int correctNumber = 7;

                // Create a new random object.
                Random random = new Random();

                // Initialize correct number.
                int correctNumber = random.Next(1, 10);

                // Initialize guess var.
                int guess = 0;

                // Ask user for number.
                Console.WriteLine("Guess a number between 1 and 10.");

                // While guess is not correct.
                while (guess != correctNumber)
                {
                    // Get users input.
                    string input = Console.ReadLine();

                    // Make sure it's a number.
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message.
                        PrintColourMessage(ConsoleColor.Red, "Please input a number");

                        // Keep going.
                        continue;
                    }

                    // Cast to int and put in guess.
                    guess = Int32.Parse(input);

                    // Match guess to correct number.
                    if (guess != correctNumber)
                    {
                        // Print error message.
                        PrintColourMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                // Print success message.
                PrintColourMessage(ConsoleColor.Yellow, "You are correct.");

                // Ask to play again.
                Console.WriteLine("Play again? [Y or N]");

                // Get the answer.
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Get and display app information.
        static void GetAppInfo()
        {
            // Set app variables.
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jared O'Meagher";

            // Change text colour.
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app information.
            Console.WriteLine("{0}: Version {1} by {2} ", appName, appVersion, appAuthor);

            // Reset text colour.
            Console.ResetColor();
        }

        // Ask for user's name and greet.
        static void GreetUser()
        {
            // Ask users name.
            Console.WriteLine("What is your name?");

            // Get user input.
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print colour message.
        static void PrintColourMessage(ConsoleColor color, string message)
        {
            // Change text colour.
            Console.ForegroundColor = color;

            // Tell user it's not a number.
            Console.WriteLine(message);

            // Reset text colour.
            Console.ResetColor();
        }
    }
}
