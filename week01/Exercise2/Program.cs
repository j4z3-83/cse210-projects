using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string Percentage = Console.ReadLine();
        int PercentNum = int.Parse(Percentage);
        string Letter;
        string PlusMinus;
        
        if(PercentNum >= 90)
        {
            Letter = "A";
        }
        else if (PercentNum >= 80)
        {
            Letter = "B";
        }
        else if (PercentNum >= 70)
        {
            Letter = "C";
        }
        else if (PercentNum >= 60)
        {
            Letter = "D"; 
        }
        else
        {
            Letter = "F";
        }

        if(PercentNum >=94 || PercentNum < 60)
        {
            PlusMinus = "";
        }
        else if (PercentNum % 10 >= 7)
        {
            PlusMinus = "+";
        }
        else if (PercentNum % 10 <= 3)
        {
            PlusMinus = "-";
        }
        else
        {
            PlusMinus = "";
        }
        
        Console.WriteLine($"Your letter grade is: {Letter}{PlusMinus}");
        
        if (PercentNum >= 70)
        {
            Console.WriteLine("Congratulations on passing the class");
        }
        else
        {
            Console.WriteLine("You have failed the class, better luck next time.");
        }
    }
}