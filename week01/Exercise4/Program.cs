using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int Num = -1;
        float Total = 0;
        float Average = 0;
        int Max = 0;
        int Min = 99999999;
        List<int> Numbers = new List<int>();
        while (Num != 0)
        {
            Console.Write("Enter a number. ");
            string Entry = Console.ReadLine();
            Num = int.Parse(Entry);
            if (Num != 0)
            {
                Numbers.Add(Num);
            }
        }

        for (int i = 0; i < Numbers.Count; i++)
        {
            Total += Numbers[i];
            if (Max < Numbers[i])
            {
                Max = Numbers[i];
            }
            if (Numbers[i] < Min && Numbers[i] > 0)
            {
                Min = Numbers[i];
            }
        }
        Console.WriteLine($"The total is: {Total}");
        Average = Total / Numbers.Count;
        Console.WriteLine($"The average is: {Average}");
        Console.WriteLine($"The highest number is: {Max}");
        Console.WriteLine($"Small positive number is: {Min}");
        Numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        for (int i = 0; i < Numbers.Count; i++)
        {
            Console.WriteLine(Numbers[i]);
        }
    }
}