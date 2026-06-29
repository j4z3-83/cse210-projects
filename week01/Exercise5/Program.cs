using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }
    
    static int SquareNumber(int number)
        {
           int squaredNumber = number * number;
           return squaredNumber; 
        }

    static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your favourite number is {number}.");
        }




       

    }
}