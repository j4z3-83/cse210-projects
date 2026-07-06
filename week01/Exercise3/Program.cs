using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess;
            int guessCount = 0;
            string attempts;
            do
            {
                Console.Write("What is your guess? ");
                string guessNum = Console.ReadLine();
                guess = int.Parse(guessNum);
                guessCount++;
                if(guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    if (guessCount == 1)
                    {
                        attempts = "Guess";
                    }
                    else
                    {
                        attempts = "Guesses";
                    }

                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} {attempts}.");
                }
            } while (guess != number);
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        }
    }
}