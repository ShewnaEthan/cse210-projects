using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string userGuessString = Console.ReadLine();

        int userGuess = int.Parse(userGuessString);
        while (userGuess != magicNum)
        {
            if (userGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            userGuessString = Console.ReadLine();
            userGuess = int.Parse(userGuessString);
        }
        Console.WriteLine("You guessed it!");
    }
}