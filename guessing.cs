using System;

public class GuessingGame
{
	public static void Main(string[] args)
	{
		// Set game parameters
		int minNumber = 1;
		int maxNumber = 100;
		int maxTries = 10;
		// Generate random number
		Random random = new Random();
		int randomNumber = random.Next(minNumber, maxNumber + 1); // Include maxNumber
		// Welcome message
		Console.WriteLine("Welcome to the Guessing Game!");
		Console.WriteLine("I'm thinking of a number between " + minNumber + " and " + maxNumber);
		Console.WriteLine("You have " + maxTries + " tries to guess it.");
		// Game loop
		int guessCount = 0;
		bool isGuessCorrect = false;
		while (guessCount < maxTries && !isGuessCorrect)
		{
			int guess;
			// Get user input with error handling
			do
			{
				Console.Write("Enter your guess: ");
				string input = Console.ReadLine();
				if (int.TryParse(input, out guess) && guess >= minNumber && guess <= maxNumber)
				{
					break;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a number between {0} and {1}.", minNumber, maxNumber);
				}
			}
			while (true);
			guessCount++;
			// Check guess and provide feedback
			if (guess == randomNumber)
			{
				isGuessCorrect = true;
				Console.WriteLine("Congratulations! You guessed the number in {0} tries.", guessCount);
			}
			else if (guess < randomNumber)
			{
				Console.WriteLine("Too low. Try again.");
			}
			else
			{
				Console.WriteLine("Too high. Try again.");
			}
		}

		// End message
		if (isGuessCorrect)
		{
			Console.WriteLine("You win!");
		}
		else
		{
			Console.WriteLine("Sorry, you ran out of tries. The number was {0}.", randomNumber);
		}
	}
}
