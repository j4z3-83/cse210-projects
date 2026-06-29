using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string percentage = Console.ReadLine();
        int percentNum = int.Parse(percentage);
        string letter;
        string plusMinus;
        
        if(percentNum >= 90)
        {
            letter = "A";
        }
        else if (percentNum >= 80)
        {
            letter = "B";
        }
        else if (percentNum >= 70)
        {
            letter = "C";
        }
        else if (percentNum >= 60)
        {
            letter = "D"; 
        }
        else
        {
            letter = "F";
        }

        if(percentNum >=94 || percentNum < 60)
        {
            plusMinus = "";
        }
        else if (percentNum % 10 >= 7)
        {
            plusMinus = "+";
        }
        else if (percentNum % 10 <= 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }
        
        Console.WriteLine($"Your letter grade is: {letter}{plusMinus}");
        
        if (percentNum >= 70)
        {
            Console.WriteLine("Congratulations on passing the class");
        }
        else
        {
            Console.WriteLine("You have failed the class, better luck next time.");
        }
    }
}