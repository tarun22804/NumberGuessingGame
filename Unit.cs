using System;

class Unit
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Generates a number between 1 and 100
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("🎲 Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");

        while (userGuess != numberToGuess)
        {
            Console.Write("\nEnter your guess: ");
            string input = Console.ReadLine();
            attempts++;

            
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("⚠ Invalid input! Please enter a number.");
                continue;
            }

            
            if (userGuess < numberToGuess)
                Console.WriteLine("🔼 Too low! Try again.");
            else if (userGuess > numberToGuess)
                Console.WriteLine("🔽 Too high! Try again.");
        }

        Console.WriteLine($"🎉 Congratulations! You guessed the number in {attempts} attempts.");
    }
}
