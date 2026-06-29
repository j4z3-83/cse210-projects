using System;

class Program
{
    static void Main(string[] args)
    {
        string PlayAgain = "yes";
        while (PlayAgain == "yes")
        {
            Random randomGenerator = new Random();
            int Number = randomGenerator.Next(1, 100);
            int Guess;
            int GuessCount = 0;
            string Attempts;
            do
            {
                Console.Write("What is your guess? ");
                string GuessNum = Console.ReadLine();
                Guess = int.Parse(GuessNum);
                GuessCount++;
                if(Guess < Number)
                {
                    Console.WriteLine("Higher");
                }
                else if (Guess > Number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    if (GuessCount == 1)
                    {
                        Attempts = "Guess";
                    }
                    else
                    {
                        Attempts = "Guesses";
                    }

                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {GuessCount} {Attempts}.");
                }
            } while (Guess != Number);
            Console.Write("Would you like to play again? ");
            PlayAgain = Console.ReadLine();
        }
    }
}