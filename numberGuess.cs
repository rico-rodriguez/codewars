using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess within the range to play.");

            // Keep track of the number of guesses and the current user guess
            int numGuesses = 0;
            int userGuess = 0;
            // Start the game and run until user quits or guesses correctly
            try {
            while (userGuess != theNumber && userGuess != -1)
            {
                // Get the user's guess
                userGuess = int.Parse(Console.ReadLine());
                // Increment the number of guesses
                numGuesses++;
                // If the user gave up, tell them the number
                if (userGuess == -1 || userGuess < 0 || userGuess > 20)
                {
                    Console.WriteLine("You failed. The number was {0}.", theNumber);
                }
                // If the user's guess is too high, tell them
                else if (userGuess > theNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                // If the user's guess is too low, tell them
                else if (userGuess < theNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                // If the user's guess is correct, congratulate them
                else
                {
                    Console.WriteLine("You got it! You guessed the number in {0} guesses.", numGuesses);
                }
            }
            } catch {
                Console.WriteLine("There was a problem with your input. Please try again.");
            }
            // HINT: You'll need a way to convert the user's input to an integer
        }
    }
}
