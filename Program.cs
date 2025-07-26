using System;

namespace BetterGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "codemikemike";
            Random random = new Random();
            int correctNumber = random.Next(1, 11);
            int guess = 0;
            int maxGuesses = 5;
            int guessesTaken = 0;

            Console.WriteLine("Guess the number between 1 and 10!");
            Console.WriteLine($"You have {maxGuesses} attempts.");
            Console.WriteLine($"Type '{secretWord}' at any time to reveal the correct number.");

            do
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (input == secretWord)
                {
                    Console.WriteLine($"Secret word entered! The correct number was {correctNumber}.");
                    break;
                }

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                guessesTaken++;

                if (guess == correctNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                    break;
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else // guess > correctNumber
                {
                    Console.WriteLine("Too high! Try again.");
                }

                Console.WriteLine($"Guesses left: {maxGuesses - guessesTaken}");

                if (guessesTaken >= maxGuesses)
                {
                    Console.WriteLine($"Game over! The correct number was {correctNumber}.");
                    break;
                }

            } while (true);
        }
    }
}